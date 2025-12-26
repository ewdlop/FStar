#light "off"
module StatefulLens

let upd_ref = (fun ( r  :  'a FStar_ST.ref ) ( v  :  'a ) -> (failwith "Not yet implemented: StatefulLens.upd_ref"))

type ('a, 'b) hlens =
{get : unit; put : unit}


let as_hlens = (fun ( l  :  ('a, 'b) Lens.lens ) -> {get = (); put = ()})


let compose_hlens = (fun ( l  :  ('a, 'b) hlens ) ( m  :  ('b, 'c) hlens ) -> {get = (); put = ()})

type ('a, 'b, 'l) stlens =
{st_get : 'a  ->  'b; st_put : 'b  ->  'a  ->  'a}


let __proj__Mkstlens__item__st_get = (fun ( l  :  ('a, 'b) hlens ) ( projectee  :  ('a, 'b, obj) stlens ) -> (match (projectee) with
| {st_get = st_get; st_put = st_put} -> begin
st_get
end))


let __proj__Mkstlens__item__st_put = (fun ( l  :  ('a, 'b) hlens ) ( projectee  :  ('a, 'b, obj) stlens ) -> (match (projectee) with
| {st_get = st_get; st_put = st_put} -> begin
st_put
end))


let compose_stlens = (fun ( l  :  ('a, 'b) hlens ) ( m  :  ('b, 'c) hlens ) ( sl  :  ('a, 'b, obj) stlens ) ( sm  :  ('b, 'c, obj) stlens ) -> {st_get = (fun ( x  :  'a ) -> (

let uu___ = (sl.st_get x)
in (sm.st_get uu___))); st_put = (fun ( z  :  'c ) ( x  :  'a ) -> (

let uu___ = (

let uu___1 = (sl.st_get x)
in (sm.st_put z uu___1))
in (sl.st_put uu___ x)))})


let as_stlens = (fun ( l  :  ('a, 'b) Lens.lens ) -> {st_get = (fun ( x  :  'a ) -> (Lens.op_String_Access x l)); st_put = (fun ( y  :  'b ) ( x  :  'a ) -> (Lens.op_String_Assignment x l y))})


let hlens_ref = (fun ( uu___  :  unit ) -> {get = (); put = ()})


let stlens_ref = (fun ( uu___  :  unit ) -> {st_get = (fun ( x  :  'a FStar_ST.ref ) -> (FStar_Ref.op_Bang x)); st_put = (fun ( y  :  'a ) ( x  :  'a FStar_ST.ref ) -> ((upd_ref x y);
x;
))})


let test0 : Prims.int FStar_ST.ref FStar_ST.ref  ->  Prims.int = (fun ( c  :  Prims.int FStar_ST.ref FStar_ST.ref ) -> ((compose_stlens (hlens_ref ()) (hlens_ref ()) (stlens_ref ()) (stlens_ref ())).st_get c))


let test1 : Prims.int FStar_ST.ref FStar_ST.ref  ->  Prims.int FStar_ST.ref FStar_ST.ref = (fun ( c  :  Prims.int FStar_ST.ref FStar_ST.ref ) -> ((compose_stlens (hlens_ref ()) (hlens_ref ()) (stlens_ref ()) (stlens_ref ())).st_put (Prims.parse_int "0") c))


let test2 : Prims.int FStar_ST.ref FStar_ST.ref  ->  Prims.int FStar_ST.ref FStar_ST.ref = (fun ( c  :  Prims.int FStar_ST.ref FStar_ST.ref ) -> (

let i = ((compose_stlens (hlens_ref ()) (hlens_ref ()) (stlens_ref ()) (stlens_ref ())).st_get c)
in ((compose_stlens (hlens_ref ()) (hlens_ref ()) (stlens_ref ()) (stlens_ref ())).st_put i c)))


let op_Bar_Dot_Dot = (fun ( l  :  ('a, 'b) hlens ) ( m  :  ('b, 'c) hlens ) -> (compose_stlens l m))


let op_Tilde_Dot = (fun ( l  :  ('a, 'b) Lens.lens ) -> (as_stlens l))


let op_Bar_Dot_Dot_Dot = (fun ( l  :  ('a, 'b) hlens ) ( sl  :  ('a, 'b, obj) stlens ) ( m  :  ('b, 'c) Lens.lens ) -> (op_Bar_Dot_Dot l (as_hlens m) sl (op_Tilde_Dot m)))


let op_String_Access = (fun ( l  :  ('a, 'b) hlens ) ( x  :  'a ) ( sl  :  ('a, 'b, obj) stlens ) -> (sl.st_get x))


let op_String_Assignment = (fun ( l  :  ('a, 'b) hlens ) ( x  :  'a ) ( sl  :  ('a, 'b, obj) stlens ) ( y  :  'b ) -> (

let uu___ = (sl.st_put y x)
in ()))


let v = (fun ( uu___  :  unit ) -> (stlens_ref ()))


let deref = (fun ( uu___  :  unit ) -> (v ()))


let test3 : Prims.int FStar_ST.ref FStar_ST.ref  ->  Prims.int = (fun ( c  :  Prims.int FStar_ST.ref FStar_ST.ref ) -> (op_String_Access (compose_hlens (hlens_ref ()) (hlens_ref ())) c (op_Bar_Dot_Dot (hlens_ref ()) (hlens_ref ()) (v ()) (v ()))))


let test4 : Prims.int FStar_ST.ref FStar_ST.ref  ->  unit = (fun ( c  :  Prims.int FStar_ST.ref FStar_ST.ref ) -> (

let uu___ = (op_String_Access (compose_hlens (hlens_ref ()) (hlens_ref ())) c (op_Bar_Dot_Dot (hlens_ref ()) (hlens_ref ()) (v ()) (v ())))
in (op_String_Assignment (compose_hlens (hlens_ref ()) (hlens_ref ())) c (op_Bar_Dot_Dot (hlens_ref ()) (hlens_ref ()) (v ()) (v ())) uu___)))


let test5 : Lens.circle FStar_ST.ref Lens.colored FStar_ST.ref Lens.colored FStar_ST.ref  ->  unit = (fun ( c  :  Lens.circle FStar_ST.ref Lens.colored FStar_ST.ref Lens.colored FStar_ST.ref ) -> (op_String_Assignment (compose_hlens (compose_hlens (compose_hlens (compose_hlens (compose_hlens (compose_hlens (hlens_ref ()) (as_hlens (Lens.payload ()))) (hlens_ref ())) (as_hlens (Lens.payload ()))) (hlens_ref ())) (as_hlens Lens.center)) (as_hlens Lens.x)) c (op_Bar_Dot_Dot_Dot (compose_hlens (compose_hlens (compose_hlens (compose_hlens (compose_hlens (hlens_ref ()) (as_hlens (Lens.payload ()))) (hlens_ref ())) (as_hlens (Lens.payload ()))) (hlens_ref ())) (as_hlens Lens.center)) (op_Bar_Dot_Dot_Dot (compose_hlens (compose_hlens (compose_hlens (compose_hlens (hlens_ref ()) (as_hlens (Lens.payload ()))) (hlens_ref ())) (as_hlens (Lens.payload ()))) (hlens_ref ())) (op_Bar_Dot_Dot (compose_hlens (compose_hlens (compose_hlens (hlens_ref ()) (as_hlens (Lens.payload ()))) (hlens_ref ())) (as_hlens (Lens.payload ()))) (hlens_ref ()) (op_Bar_Dot_Dot_Dot (compose_hlens (compose_hlens (hlens_ref ()) (as_hlens (Lens.payload ()))) (hlens_ref ())) (op_Bar_Dot_Dot (compose_hlens (hlens_ref ()) (as_hlens (Lens.payload ()))) (hlens_ref ()) (op_Bar_Dot_Dot_Dot (hlens_ref ()) (v ()) (Lens.payload ())) (v ())) (Lens.payload ())) (v ())) Lens.center) Lens.x) (Prims.parse_int "17")))

type point =
{x : Prims.int FStar_ST.ref; y : Prims.int FStar_ST.ref}


let __proj__Mkpoint__item__x : point  ->  Prims.int FStar_ST.ref = (fun ( projectee  :  point ) -> (match (projectee) with
| {x = x; y = y} -> begin
x
end))


let __proj__Mkpoint__item__y : point  ->  Prims.int FStar_ST.ref = (fun ( projectee  :  point ) -> (match (projectee) with
| {x = x; y = y} -> begin
y
end))

type circle =
{center : point FStar_ST.ref; radius : Prims.nat FStar_ST.ref}


let __proj__Mkcircle__item__center : circle  ->  point FStar_ST.ref = (fun ( projectee  :  circle ) -> (match (projectee) with
| {center = center; radius = radius} -> begin
center
end))


let __proj__Mkcircle__item__radius : circle  ->  Prims.nat FStar_ST.ref = (fun ( projectee  :  circle ) -> (match (projectee) with
| {center = center; radius = radius} -> begin
radius
end))


let center : (circle, point FStar_ST.ref) Lens.lens = {Lens.get = (fun ( c  :  circle ) -> c.center); Lens.put = (fun ( p  :  point FStar_ST.ref ) ( c  :  circle ) -> {center = p; radius = c.radius})}


let x : (point, Prims.int FStar_ST.ref) Lens.lens = {Lens.get = (fun ( p  :  point ) -> p.x); Lens.put = (fun ( x1  :  Prims.int FStar_ST.ref ) ( p  :  point ) -> {x = x1; y = p.y})}


let op_Bar_Hat_Dot = (fun ( l  :  ('b, 'c) hlens ) ( m  :  ('a, 'b) Lens.lens ) ( sl  :  ('b, 'c, obj) stlens ) -> (op_Bar_Dot_Dot (as_hlens m) l (op_Tilde_Dot m) sl))


let op_Bar_Dot_Hat = (fun ( l  :  ('a, 'b) hlens ) ( sl  :  ('a, 'b, obj) stlens ) ( m  :  ('b, 'c) Lens.lens ) -> (op_Bar_Dot_Dot l (as_hlens m) sl (op_Tilde_Dot m)))


let op_Bar_Dot = (fun ( m  :  ('a, 'b) Lens.lens ) ( n  :  ('b, 'c) Lens.lens ) -> (Lens.op_Bar_Dot_Dot m n))


let move_x : Prims.int  ->  circle  ->  unit = (fun ( delta  :  Prims.int ) ( c  :  circle ) -> (

let uu___ = (

let uu___1 = (op_String_Access (compose_hlens (compose_hlens (compose_hlens (as_hlens center) (hlens_ref ())) (as_hlens x)) (hlens_ref ())) c (op_Bar_Dot_Dot (compose_hlens (compose_hlens (as_hlens center) (hlens_ref ())) (as_hlens x)) (hlens_ref ()) (op_Bar_Dot_Hat (compose_hlens (as_hlens center) (hlens_ref ())) (op_Bar_Hat_Dot (hlens_ref ()) center (v ())) x) (v ())))
in (uu___1 + delta))
in (op_String_Assignment (compose_hlens (compose_hlens (compose_hlens (as_hlens center) (hlens_ref ())) (as_hlens x)) (hlens_ref ())) c (op_Bar_Dot_Dot (compose_hlens (compose_hlens (as_hlens center) (hlens_ref ())) (as_hlens x)) (hlens_ref ()) (op_Bar_Dot_Hat (compose_hlens (as_hlens center) (hlens_ref ())) (op_Bar_Hat_Dot (hlens_ref ()) center (v ())) x) (v ())) uu___)))


let move_x2 : Prims.int  ->  circle  ->  unit = (fun ( delta  :  Prims.int ) ( c  :  circle ) -> (

let uu___ = (

let uu___1 = (op_String_Access (compose_hlens (compose_hlens (compose_hlens (as_hlens center) (hlens_ref ())) (as_hlens x)) (hlens_ref ())) c (op_Bar_Dot_Dot (compose_hlens (compose_hlens (as_hlens center) (hlens_ref ())) (as_hlens x)) (hlens_ref ()) (op_Bar_Dot_Hat (compose_hlens (as_hlens center) (hlens_ref ())) (op_Bar_Hat_Dot (hlens_ref ()) center (v ())) x) (v ())))
in (uu___1 + delta))
in (op_String_Assignment (compose_hlens (compose_hlens (compose_hlens (as_hlens center) (hlens_ref ())) (as_hlens x)) (hlens_ref ())) c (op_Bar_Dot_Dot (compose_hlens (compose_hlens (as_hlens center) (hlens_ref ())) (as_hlens x)) (hlens_ref ()) (op_Bar_Dot_Hat (compose_hlens (as_hlens center) (hlens_ref ())) (op_Bar_Hat_Dot (hlens_ref ()) center (v ())) x) (v ())) uu___)))




