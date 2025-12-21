(*
   Copyright 2008-2024 Microsoft Research

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
module FStar.Class.Monad

open FStar.Tactics.Typeclasses

(** Monad laws: a record containing the three monad laws *)
noeq
type monad_laws (m:Type0 -> Type0) 
                (return : (#a:_ -> a -> m a)) 
                (bind : (#a:_ -> #b:_ -> m a -> (a -> m b) -> m b)) = {
  (** Left identity: return a >>= f == f a *)
  idL    : #a:_ -> #b:_ -> x:a -> f:(a -> m b) -> 
           Lemma (bind (return x) f == f x);
  (** Right identity: m >>= return == m *)
  idR    : #a:_ -> x:m a -> 
           Lemma (bind x return == x);
  (** Associativity: (m >>= f) >>= g == m >>= (\x -> f x >>= g) *)
  assoc  : #a:_ -> #b:_ -> #c:_ -> x:m a -> f:(a -> m b) -> g:(b -> m c) ->
           Lemma (bind (bind x f) g == bind x (fun y -> bind (f y) g));
}

(** The monad typeclass *)
class monad (m : Type0 -> Type0) = {
  (** return/pure operation: lift a value into the monad *)
  [@@ tcmethod]
  return : #a:_ -> a -> m a;
  (** bind operation: sequence monadic computations *)
  [@@ tcmethod]
  bind   : #a:_ -> #b:_ -> m a -> (a -> m b) -> m b;
  (** Proof that the monad laws hold *)
  [@@ no_method]
  laws   : monad_laws m return bind;
}

(** Infix operator for bind *)
let op_Greater_Greater_Equals (#m:Type0 -> Type0) {| monad m |} 
                               (#a:_) (#b:_) (x : m a) (f : a -> m b) : m b =
  bind x f

(** Sequencing operator: ignore the result of the first computation *)
let op_Greater_Greater (#m:Type0 -> Type0) {| monad m |} 
                        (#a:_) (#b:_) (x : m a) (y : m b) : m b =
  bind x (fun _ -> y)
