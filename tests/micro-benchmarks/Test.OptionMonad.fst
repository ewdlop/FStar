(*
   Copyright 2024 Microsoft Research

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
module Test.OptionMonad

open FStar.Class.Monad
open FStar.Option

(** Test that we can use the monad operations *)
let test_return : option int = 
  return #option 42

let test_bind : option int =
  bind #option (Some 10) (fun x -> Some (x + 5))

(** Test using the infix operators *)
let test_bind_op : option int =
  Some 10 >>= (fun x -> Some (x + 5))

let test_sequence : option int =
  Some 10 >> Some 20

(** Test chaining multiple binds *)
let test_chain : option int =
  Some 3 >>= (fun x ->
  Some 4 >>= (fun y ->
  return (x + y)))

(** Test that None propagates correctly *)
let test_none_propagation : option int =
  None >>= (fun x -> Some (x + 1))

(** Verify the result is None *)
let _ = assert (test_none_propagation == None)

(** Test with existing let? syntax *)
let test_let_syntax : option int =
  let? x = Some 3 in
  let? y = Some 4 in
  Some (x + y)
