(*
   Copyright 2008-2014 Nikhil Swamy and Microsoft Research

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*)
module FStar.Option

open FStar.All

inline_for_extraction
val isNone: option 'a -> Tot bool
inline_for_extraction
let isNone = function
  | None -> true
  | Some _ -> false

inline_for_extraction
val isSome: option 'a -> Tot bool
inline_for_extraction
let isSome = function
  | Some _ -> true
  | None -> false

inline_for_extraction
val map: ('a -> ML 'b) -> option 'a -> ML (option 'b)
inline_for_extraction
let map f = function
  | Some x -> Some (f x)
  | None -> None

inline_for_extraction
val mapTot: ('a -> Tot 'b) -> option 'a -> Tot (option 'b)
inline_for_extraction
let mapTot f = function
  | Some x -> Some (f x)
  | None -> None

inline_for_extraction
val get: option 'a -> ML 'a
let get = function
  | Some x -> x
  | None -> failwith "empty option"

let (let?) (x: option 'a) (f: 'a -> option 'b): option 'b
  = match x with
  | Some x -> f x
  | None   -> None

let (and?) (x: option 'a) (y: option 'b): option ('a & 'b)
  = match x, y with
  | Some x, Some y -> Some (x, y)
  | _ -> None

(** Monad operations for option *)

let return_option (#a:Type) (x:a) : option a = Some x

let bind_option (#a:Type) (#b:Type) (x:option a) (f:a -> option b) : option b =
  let? v = x in f v

(** Proofs of monad laws for option *)

let option_law_idL (#a:Type) (#b:Type) (x:a) (f:a -> option b) 
  : Lemma (bind_option (return_option x) f == f x) = ()

let option_law_idR (#a:Type) (x:option a) 
  : Lemma (bind_option x return_option == x) 
  = match x with
    | Some _ -> ()
    | None -> ()

let option_law_assoc (#a:Type) (#b:Type) (#c:Type) 
                      (x:option a) (f:a -> option b) (g:b -> option c)
  : Lemma (bind_option (bind_option x f) g == 
           bind_option x (fun y -> bind_option (f y) g))
  = match x with
    | Some _ -> ()
    | None -> ()

open FStar.Class.Monad

instance monad_option : monad option = {
  return = return_option;
  bind = bind_option;
  laws = {
    idL = option_law_idL;
    idR = option_law_idR;
    assoc = option_law_assoc;
  };
}
