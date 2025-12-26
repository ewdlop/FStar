#light "off"
module FStar_LexicographicOrdering
type ('a, 'b, 'rua, 'rub, 'dummyV0, 'dummyV1) lex_t =
| Left_lex of 'a * 'a * 'b * 'b * 'rua
| Right_lex of 'a * 'b * 'b * 'rub


let uu___is_Left_lex = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Left_lex (x1, x2, y1, y2, _4) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__Left_lex__item__x1 = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Left_lex (x1, x2, y1, y2, _4) -> begin
x1
end))


let __proj__Left_lex__item__x2 = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Left_lex (x1, x2, y1, y2, _4) -> begin
x2
end))


let __proj__Left_lex__item__y1 = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Left_lex (x1, x2, y1, y2, _4) -> begin
y1
end))


let __proj__Left_lex__item__y2 = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Left_lex (x1, x2, y1, y2, _4) -> begin
y2
end))


let __proj__Left_lex__item___4 = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Left_lex (x1, x2, y1, y2, _4) -> begin
_4
end))


let uu___is_Right_lex = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Right_lex (x, y1, y2, _3) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__Right_lex__item__x = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Right_lex (x, y1, y2, _3) -> begin
x
end))


let __proj__Right_lex__item__y1 = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Right_lex (x, y1, y2, _3) -> begin
y1
end))


let __proj__Right_lex__item__y2 = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Right_lex (x, y1, y2, _3) -> begin
y2
end))


let __proj__Right_lex__item___3 = (fun ( uu___  :  ('a, 'b) Prims.dtuple2 ) ( uu___1  :  ('a, 'b) Prims.dtuple2 ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) lex_t ) -> (match (projectee) with
| Right_lex (x, y1, y2, _3) -> begin
_3
end))





type lex_aux =
obj


type lex =
obj


let tuple_to_dep_tuple = (fun ( x  :  ('a * 'b) ) -> Prims.Mkdtuple2 ((FStar_Pervasives_Native.fst x), (FStar_Pervasives_Native.snd x)))


type ('a, 'b, 'rua, 'rub) lex_t_non_dep =
('a, 'b, 'rua, 'rub, obj, obj) lex_t




type ('a, 'b, 'rua, 'rub, 'dummyV0, 'dummyV1) sym =
| Left_sym of 'a * 'a * 'b * 'rua
| Right_sym of 'a * 'b * 'b * 'rub


let uu___is_Left_sym = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Left_sym (x1, x2, y, _3) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__Left_sym__item__x1 = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Left_sym (x1, x2, y, _3) -> begin
x1
end))


let __proj__Left_sym__item__x2 = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Left_sym (x1, x2, y, _3) -> begin
x2
end))


let __proj__Left_sym__item__y = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Left_sym (x1, x2, y, _3) -> begin
y
end))


let __proj__Left_sym__item___3 = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Left_sym (x1, x2, y, _3) -> begin
_3
end))


let uu___is_Right_sym = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Right_sym (x, y1, y2, _3) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__Right_sym__item__x = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Right_sym (x, y1, y2, _3) -> begin
x
end))


let __proj__Right_sym__item__y1 = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Right_sym (x, y1, y2, _3) -> begin
y1
end))


let __proj__Right_sym__item__y2 = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Right_sym (x, y1, y2, _3) -> begin
y2
end))


let __proj__Right_sym__item___3 = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) ( projectee  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (projectee) with
| Right_sym (x, y1, y2, _3) -> begin
_3
end))


let sym_sub_lex = (fun ( t1  :  ('a * 'b) ) ( t2  :  ('a * 'b) ) ( p  :  ('a, 'b, 'rua, 'rub, obj, obj) sym ) -> (match (p) with
| Left_sym (x1, x2, y, p1) -> begin
Left_lex (x1, x2, y, y, p1)
end
| Right_sym (x, y1, y2, p1) -> begin
Right_lex (x, y1, y2, p1)
end))







