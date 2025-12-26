#light "off"
module FStar_Algebra_CommMonoid_Equiv
type 'a equiv =
| EQ of unit * unit * unit * unit


let uu___is_EQ = (fun ( projectee  :  'a equiv ) -> true)


let equality_equiv = (fun ( uu___  :  unit ) -> EQ ((), (), (), ()))

type ('a, 'eq) cm =
| CM of 'a * ('a  ->  'a  ->  'a) * unit * unit * unit * unit


let uu___is_CM = (fun ( eq  :  'a equiv ) ( projectee  :  ('a, obj) cm ) -> true)


let __proj__CM__item__unit = (fun ( eq  :  'a equiv ) ( projectee  :  ('a, obj) cm ) -> (match (projectee) with
| CM (unit, mult, identity, associativity, commutativity, congruence) -> begin
unit
end))


let __proj__CM__item__mult = (fun ( eq  :  'a equiv ) ( projectee  :  ('a, obj) cm ) -> (match (projectee) with
| CM (unit, mult, identity, associativity, commutativity, congruence) -> begin
mult
end))


let int_plus_cm : (Prims.int, obj) cm = CM ((Prims.parse_int "0"), Prims.op_Addition, (), (), (), ())


let int_multiply_cm : (Prims.int, obj) cm = CM ((Prims.parse_int "1"), Prims.op_Multiply, (), (), (), ())




