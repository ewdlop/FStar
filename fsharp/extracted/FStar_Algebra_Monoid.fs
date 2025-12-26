#light "off"
module FStar_Algebra_Monoid

type right_unitality_lemma =
unit


type left_unitality_lemma =
unit


type associativity_lemma =
unit

type 'm monoid =
| Monoid of 'm * ('m  ->  'm  ->  'm) * unit * unit * unit


let uu___is_Monoid = (fun ( projectee  :  'm monoid ) -> true)


let __proj__Monoid__item__unit = (fun ( projectee  :  'm monoid ) -> (match (projectee) with
| Monoid (unit, mult, right_unitality, left_unitality, associativity) -> begin
unit
end))


let __proj__Monoid__item__mult = (fun ( projectee  :  'm monoid ) -> (match (projectee) with
| Monoid (unit, mult, right_unitality, left_unitality, associativity) -> begin
mult
end))


let intro_monoid = (fun ( u  :  'm ) ( mult  :  'm  ->  'm  ->  'm ) -> Monoid (u, mult, (), (), ()))


let nat_plus_monoid : Prims.nat monoid = (

let add = (fun ( x  :  Prims.nat ) ( y  :  Prims.nat ) -> (x + y))
in (intro_monoid (Prims.parse_int "0") add))


let int_plus_monoid : Prims.int monoid = (intro_monoid (Prims.parse_int "0") Prims.op_Addition)


let conjunction_monoid : unit monoid = (intro_monoid () (fun ( uu___1  :  unit ) ( uu___  :  unit ) -> ()))


let disjunction_monoid : unit monoid = (intro_monoid () (fun ( uu___1  :  unit ) ( uu___  :  unit ) -> ()))


let bool_and_monoid : Prims.bool monoid = (

let and_ = (fun ( b1  :  Prims.bool ) ( b2  :  Prims.bool ) -> (b1 && b2))
in (intro_monoid true and_))


let bool_or_monoid : Prims.bool monoid = (

let or_ = (fun ( b1  :  Prims.bool ) ( b2  :  Prims.bool ) -> (b1 || b2))
in (intro_monoid false or_))


let bool_xor_monoid : Prims.bool monoid = (

let xor = (fun ( b1  :  Prims.bool ) ( b2  :  Prims.bool ) -> ((b1 || b2) && (not ((b1 && b2)))))
in (intro_monoid false xor))


let lift_monoid_option = (fun ( m  :  'a monoid ) -> (

let mult = (fun ( x  :  'a FStar_Pervasives_Native.option ) ( y  :  'a FStar_Pervasives_Native.option ) -> (match (((x), (y))) with
| (FStar_Pervasives_Native.Some (x0), FStar_Pervasives_Native.Some (y0)) -> begin
FStar_Pervasives_Native.Some ((__proj__Monoid__item__mult m x0 y0))
end
| (uu___, uu___1) -> begin
FStar_Pervasives_Native.None
end))
in (intro_monoid (FStar_Pervasives_Native.Some ((__proj__Monoid__item__unit m))) mult)))


type monoid_morphism_unit_lemma =
unit


type monoid_morphism_mult_lemma =
unit

type ('a, 'b, 'f, 'ma, 'mb) monoid_morphism =
| MonoidMorphism of unit * unit


let uu___is_MonoidMorphism = (fun ( f  :  'a  ->  'b ) ( ma  :  'a monoid ) ( mb  :  'b monoid ) ( projectee  :  ('a, 'b, obj, obj, obj) monoid_morphism ) -> true)


let intro_monoid_morphism = (fun ( f  :  'a  ->  'b ) ( ma  :  'a monoid ) ( mb  :  'b monoid ) -> MonoidMorphism ((), ()))


let embed_nat_int : Prims.nat  ->  Prims.int = (fun ( n  :  Prims.nat ) -> n)


let uu___0 : (Prims.nat, Prims.int, obj, obj, obj) monoid_morphism = (intro_monoid_morphism embed_nat_int nat_plus_monoid int_plus_monoid)


type neg =
unit


let uu___1 : (unit, unit, neg, obj, obj) monoid_morphism = (Prims.unsafe_coerce (intro_monoid_morphism (fun ( uu___  :  unit ) -> ()) conjunction_monoid disjunction_monoid))


let uu___2 : (unit, unit, neg, obj, obj) monoid_morphism = (Prims.unsafe_coerce (intro_monoid_morphism (fun ( uu___  :  unit ) -> ()) disjunction_monoid conjunction_monoid))


type mult_act_lemma =
unit


type unit_act_lemma =
unit

type ('m, 'mm, 'a) left_action =
| LAct of ('m  ->  'a  ->  'a) * unit * unit


let uu___is_LAct = (fun ( mm  :  'm monoid ) ( a  :  unit ) ( projectee  :  ('m, obj, obj) left_action ) -> true)


let __proj__LAct__item__act = (fun ( mm  :  'm monoid ) ( a  :  unit ) ( projectee  :  ('m, obj, obj) left_action ) -> (match (projectee) with
| LAct (act, mult_lemma, unit_lemma) -> begin
act
end))


type left_action_morphism =
unit




