#light "off"
module FStar_ReflexiveTransitiveClosure

type binrel =
unit


type predicate =
unit


type reflexive =
unit


type transitive =
unit


type preorder_rel =
unit


type preorder =
unit


type stable =
unit

type ('a, 'r, 'dummyV0, 'dummyV1) _closure =
| Refl of 'a
| Step of 'a * 'a * unit
| Closure of 'a * 'a * 'a * ('a, 'r, obj, obj) _closure * ('a, 'r, obj, obj) _closure


let uu___is_Refl = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Refl (x) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__Refl__item__x = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Refl (x) -> begin
x
end))


let uu___is_Step = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Step (x, y, _2) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__Step__item__x = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Step (x, y, _2) -> begin
x
end))


let __proj__Step__item__y = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Step (x, y, _2) -> begin
y
end))


let uu___is_Closure = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Closure (x, y, z, _3, _4) -> begin
true
end
| uu___2 -> begin
false
end))


let __proj__Closure__item__x = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Closure (x, y, z, _3, _4) -> begin
x
end))


let __proj__Closure__item__y = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Closure (x, y, z, _3, _4) -> begin
y
end))


let __proj__Closure__item__z = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Closure (x, y, z, _3, _4) -> begin
z
end))


let __proj__Closure__item___3 = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Closure (x, y, z, _3, _4) -> begin
_3
end))


let __proj__Closure__item___4 = (fun ( uu___  :  'a ) ( uu___1  :  'a ) ( projectee  :  ('a, 'r, obj, obj) _closure ) -> (match (projectee) with
| Closure (x, y, z, _3, _4) -> begin
_4
end))


type _closure0 =
unit



let rec closure_one_aux = (fun ( x  :  'a ) ( y  :  'a ) ( xy  :  ('a, 'r, obj, obj) _closure ) -> (match (xy) with
| Refl (uu___) -> begin
FStar_Pervasives.Inl (())
end
| Step (uu___, uu___1, pr) -> begin
FStar_Pervasives.Inr (FStar_Pervasives.Mkdtuple3 (y, (), Refl (y)))
end
| Closure (x1, i, y1, xi, iy) -> begin
(match ((closure_one_aux i y1 iy)) with
| FStar_Pervasives.Inl (uu___) -> begin
(closure_one_aux x1 y1 xi)
end
| FStar_Pervasives.Inr (FStar_Pervasives.Mkdtuple3 (z, r_i_z, c_z_y)) -> begin
(

let c_z_y1 = c_z_y
in (match ((closure_one_aux x1 i xi)) with
| FStar_Pervasives.Inl (uu___) -> begin
FStar_Pervasives.Inr (FStar_Pervasives.Mkdtuple3 (z, (), c_z_y1))
end
| FStar_Pervasives.Inr (FStar_Pervasives.Mkdtuple3 (w, r_x_w, c_w_i)) -> begin
(

let step = Step (i, z, ())
in (

let c_i_y = Closure (i, z, y1, step, c_z_y1)
in (

let c_w_y = Closure (w, i, y1, c_w_i, c_i_y)
in FStar_Pervasives.Inr (FStar_Pervasives.Mkdtuple3 (w, (), c_w_y)))))
end))
end)
end))




