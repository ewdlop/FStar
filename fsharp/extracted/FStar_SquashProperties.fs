#light "off"
module FStar_SquashProperties

let bool_of_or = (fun ( t  :  ('p, 'q) Prims.sum ) -> (match (t) with
| Prims.Left (uu___) -> begin
true
end
| Prims.Right (uu___) -> begin
false
end))


type pow =
unit

type ('a, 'b) retract =
| MkR of unit * unit * unit


let uu___is_MkR = (fun ( projectee  :  ('a, 'b) retract ) -> true)

type ('a, 'b) retract_cond =
| MkC of unit * unit * unit


let uu___is_MkC = (fun ( projectee  :  ('a, 'b) retract_cond ) -> true)


let false_elim = (fun ( uu___  :  unit ) -> ((fun ( f  :  unit ) -> (Prims.unsafe_coerce (failwith "unreachable"))) uu___))


type u =
unit




