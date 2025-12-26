#light "off"
module FStar_Pervasives

type pattern =
unit








type eqtype_u =
unit


type 'p spinoff =
'p


let id = (fun ( x  :  'a ) -> x)


type trivial_pure_post =
unit


type ambient =
unit


type pure_return =
unit


type 'wp1 pure_bind_wp =
'wp1


type pure_if_then_else =
unit


type pure_ite_wp =
unit


type pure_close_wp =
unit


type pure_null_wp =
unit


type pure_assert_wp =
unit


type pure_assume_wp =
unit


type 'wp pure_wp_intro =
'wp


type div_hoare_to_wp =
unit


type st_pre_h =
unit


type st_post_h' =
unit


type st_post_h =
unit


type st_wp_h =
unit


type 'p st_return =
'p


type 'wp1 st_bind_wp =
'wp1


type st_if_then_else =
unit


type st_ite_wp =
unit


type st_stronger =
unit


type st_close_wp =
unit


type st_trivial =
unit

type 'a result =
| V of 'a
| E of Prims.exn
| Err of Prims.string


let uu___is_V = (fun ( projectee  :  'a result ) -> (match (projectee) with
| V (v) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__V__item__v = (fun ( projectee  :  'a result ) -> (match (projectee) with
| V (v) -> begin
v
end))


let uu___is_E = (fun ( projectee  :  'a result ) -> (match (projectee) with
| E (e) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__E__item__e = (fun ( projectee  :  'a result ) -> (match (projectee) with
| E (e) -> begin
e
end))


let uu___is_Err = (fun ( projectee  :  'a result ) -> (match (projectee) with
| Err (msg) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Err__item__msg = (fun ( projectee  :  'a result ) -> (match (projectee) with
| Err (msg) -> begin
msg
end))


type ex_pre =
unit


type ex_post' =
unit


type ex_post =
unit


type ex_wp =
unit


type 'p ex_return =
'p


type ex_bind_wp =
unit


type ex_if_then_else =
unit


type ex_ite_wp =
unit


type ex_stronger =
unit


type ex_close_wp =
unit


type 'wp ex_trivial =
'wp


type 'wp lift_div_exn =
'wp


type all_pre_h =
unit


type all_post_h' =
unit


type all_post_h =
unit


type all_wp_h =
unit


type 'p all_return =
'p


type 'wp1 all_bind_wp =
'wp1


type all_if_then_else =
unit


type all_ite_wp =
unit


type all_stronger =
unit


type all_close_wp =
unit


type all_trivial =
unit


type inversion =
unit

type ('a, 'b) either =
| Inl of 'a
| Inr of 'b


let uu___is_Inl = (fun ( projectee  :  ('a, 'b) either ) -> (match (projectee) with
| Inl (v) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Inl__item__v = (fun ( projectee  :  ('a, 'b) either ) -> (match (projectee) with
| Inl (v) -> begin
v
end))


let uu___is_Inr = (fun ( projectee  :  ('a, 'b) either ) -> (match (projectee) with
| Inr (v) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Inr__item__v = (fun ( projectee  :  ('a, 'b) either ) -> (match (projectee) with
| Inr (v) -> begin
v
end))


let dfst = (fun ( t  :  ('a, 'b) Prims.dtuple2 ) -> (Prims.__proj__Mkdtuple2__item___1 t))


let dsnd = (fun ( t  :  ('a, 'b) Prims.dtuple2 ) -> (Prims.__proj__Mkdtuple2__item___2 t))

type ('a, 'b, 'c) dtuple3 =
| Mkdtuple3 of 'a * 'b * 'c


let uu___is_Mkdtuple3 = (fun ( projectee  :  ('a, 'b, 'c) dtuple3 ) -> true)


let __proj__Mkdtuple3__item___1 = (fun ( projectee  :  ('a, 'b, 'c) dtuple3 ) -> (match (projectee) with
| Mkdtuple3 (_1, _2, _3) -> begin
_1
end))


let __proj__Mkdtuple3__item___2 = (fun ( projectee  :  ('a, 'b, 'c) dtuple3 ) -> (match (projectee) with
| Mkdtuple3 (_1, _2, _3) -> begin
_2
end))


let __proj__Mkdtuple3__item___3 = (fun ( projectee  :  ('a, 'b, 'c) dtuple3 ) -> (match (projectee) with
| Mkdtuple3 (_1, _2, _3) -> begin
_3
end))

type ('a, 'b, 'c, 'd) dtuple4 =
| Mkdtuple4 of 'a * 'b * 'c * 'd


let uu___is_Mkdtuple4 = (fun ( projectee  :  ('a, 'b, 'c, 'd) dtuple4 ) -> true)


let __proj__Mkdtuple4__item___1 = (fun ( projectee  :  ('a, 'b, 'c, 'd) dtuple4 ) -> (match (projectee) with
| Mkdtuple4 (_1, _2, _3, _4) -> begin
_1
end))


let __proj__Mkdtuple4__item___2 = (fun ( projectee  :  ('a, 'b, 'c, 'd) dtuple4 ) -> (match (projectee) with
| Mkdtuple4 (_1, _2, _3, _4) -> begin
_2
end))


let __proj__Mkdtuple4__item___3 = (fun ( projectee  :  ('a, 'b, 'c, 'd) dtuple4 ) -> (match (projectee) with
| Mkdtuple4 (_1, _2, _3, _4) -> begin
_3
end))


let __proj__Mkdtuple4__item___4 = (fun ( projectee  :  ('a, 'b, 'c, 'd) dtuple4 ) -> (match (projectee) with
| Mkdtuple4 (_1, _2, _3, _4) -> begin
_4
end))

type ('a, 'b, 'c, 'd, 'e) dtuple5 =
| Mkdtuple5 of 'a * 'b * 'c * 'd * 'e


let uu___is_Mkdtuple5 = (fun ( projectee  :  ('a, 'b, 'c, 'd, 'e) dtuple5 ) -> true)


let __proj__Mkdtuple5__item___1 = (fun ( projectee  :  ('a, 'b, 'c, 'd, 'e) dtuple5 ) -> (match (projectee) with
| Mkdtuple5 (_1, _2, _3, _4, _5) -> begin
_1
end))


let __proj__Mkdtuple5__item___2 = (fun ( projectee  :  ('a, 'b, 'c, 'd, 'e) dtuple5 ) -> (match (projectee) with
| Mkdtuple5 (_1, _2, _3, _4, _5) -> begin
_2
end))


let __proj__Mkdtuple5__item___3 = (fun ( projectee  :  ('a, 'b, 'c, 'd, 'e) dtuple5 ) -> (match (projectee) with
| Mkdtuple5 (_1, _2, _3, _4, _5) -> begin
_3
end))


let __proj__Mkdtuple5__item___4 = (fun ( projectee  :  ('a, 'b, 'c, 'd, 'e) dtuple5 ) -> (match (projectee) with
| Mkdtuple5 (_1, _2, _3, _4, _5) -> begin
_4
end))


let __proj__Mkdtuple5__item___5 = (fun ( projectee  :  ('a, 'b, 'c, 'd, 'e) dtuple5 ) -> (match (projectee) with
| Mkdtuple5 (_1, _2, _3, _4, _5) -> begin
_5
end))


let rec false_elim = (fun ( uu___  :  unit ) -> (false_elim ()))


let singleton = (fun ( x  :  'uuuuu ) -> x)


type 'a eqtype_as_type =
'a


let coerce_eq = (fun ( uu___1  :  unit ) ( uu___  :  'a ) -> ((fun ( uu___  :  unit ) ( x  :  'a ) -> (Prims.unsafe_coerce x)) uu___1 uu___))




