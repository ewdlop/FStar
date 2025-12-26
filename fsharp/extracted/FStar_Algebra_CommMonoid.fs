#light "off"
module FStar_Algebra_CommMonoid
type 'a cm =
| CM of 'a * ('a  ->  'a  ->  'a) * unit * unit * unit


let uu___is_CM = (fun ( projectee  :  'a cm ) -> true)


let __proj__CM__item__unit = (fun ( projectee  :  'a cm ) -> (match (projectee) with
| CM (unit, mult, identity, associativity, commutativity) -> begin
unit
end))


let __proj__CM__item__mult = (fun ( projectee  :  'a cm ) -> (match (projectee) with
| CM (unit, mult, identity, associativity, commutativity) -> begin
mult
end))


let int_plus_cm : Prims.int cm = CM ((Prims.parse_int "0"), Prims.op_Addition, (), (), ())


let int_multiply_cm : Prims.int cm = CM ((Prims.parse_int "1"), Prims.op_Multiply, (), (), ())




