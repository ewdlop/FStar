#light "off"
module Lens
type ('a, 'b) lens =
{get : 'a  ->  'b; put : 'b  ->  'a  ->  'a}


let __proj__Mklens__item__get = (fun ( projectee  :  ('a, 'b) lens ) -> (match (projectee) with
| {get = get; put = put} -> begin
get
end))


let __proj__Mklens__item__put = (fun ( projectee  :  ('a, 'b) lens ) -> (match (projectee) with
| {get = get; put = put} -> begin
put
end))


let op_Bar_Dot = (fun ( x  :  'a ) ( l  :  ('a, 'b) lens ) -> (l.get x))


let op_Bar_Colon_Equals = (fun ( x  :  'a ) ( l  :  ('a, 'b) lens ) ( b1  :  'b ) -> (l.put b1 x))


let op_Bar_Dot_Dot = (fun ( m  :  ('a, 'b) lens ) ( l  :  ('b, 'c) lens ) -> {get = (fun ( x  :  'a ) -> (l.get (m.get x))); put = (fun ( x  :  'c ) ( y  :  'a ) -> (m.put (l.put x (m.get y)) y))})


let op_String_Assignment = (fun ( x  :  'a ) ( l  :  ('a, 'b) lens ) ( v  :  'b ) -> (op_Bar_Colon_Equals x l v))


let op_String_Access = (fun ( x  :  'a ) ( l  :  ('a, 'b) lens ) -> (op_Bar_Dot x l))

type point =
{x : Prims.int; y : Prims.int; z : Prims.int}


let __proj__Mkpoint__item__x : point  ->  Prims.int = (fun ( projectee  :  point ) -> (match (projectee) with
| {x = x; y = y; z = z} -> begin
x
end))


let __proj__Mkpoint__item__y : point  ->  Prims.int = (fun ( projectee  :  point ) -> (match (projectee) with
| {x = x; y = y; z = z} -> begin
y
end))


let __proj__Mkpoint__item__z : point  ->  Prims.int = (fun ( projectee  :  point ) -> (match (projectee) with
| {x = x; y = y; z = z} -> begin
z
end))


let x : (point, Prims.int) lens = {get = (fun ( p  :  point ) -> p.x); put = (fun ( x'  :  Prims.int ) ( p  :  point ) -> {x = x'; y = p.y; z = p.z})}


let y : (point, Prims.int) lens = {get = (fun ( p  :  point ) -> p.y); put = (fun ( y'  :  Prims.int ) ( p  :  point ) -> {x = p.x; y = y'; z = p.z})}


let z : (point, Prims.int) lens = {get = (fun ( p  :  point ) -> p.z); put = (fun ( z'  :  Prims.int ) ( p  :  point ) -> {x = p.x; y = p.y; z = z'})}

type circle =
{center : point; radius : Prims.nat}


let __proj__Mkcircle__item__center : circle  ->  point = (fun ( projectee  :  circle ) -> (match (projectee) with
| {center = center; radius = radius} -> begin
center
end))


let __proj__Mkcircle__item__radius : circle  ->  Prims.nat = (fun ( projectee  :  circle ) -> (match (projectee) with
| {center = center; radius = radius} -> begin
radius
end))


let center : (circle, point) lens = {get = (fun ( c  :  circle ) -> c.center); put = (fun ( n  :  point ) ( c  :  circle ) -> {center = n; radius = c.radius})}


let radius : (circle, Prims.nat) lens = {get = (fun ( c  :  circle ) -> c.radius); put = (fun ( n  :  Prims.nat ) ( c  :  circle ) -> {center = c.center; radius = n})}


let getY : circle  ->  Prims.int = (fun ( c  :  circle ) -> (op_Bar_Dot (op_Bar_Dot c center) y))


let getY' : circle  ->  Prims.int = (fun ( c  :  circle ) -> (op_String_Access c (op_Bar_Dot_Dot center y)))


let getY'' : circle  ->  Prims.int = (fun ( c  :  circle ) -> c.center.y)


let setY : circle  ->  Prims.int  ->  circle = (fun ( c  :  circle ) ( new_y  :  Prims.int ) -> (op_String_Assignment c (op_Bar_Dot_Dot center y) new_y))


let tedious_setY : circle  ->  Prims.int  ->  circle = (fun ( c  :  circle ) ( new_y  :  Prims.int ) -> {center = (

let uu___ = c.center
in {x = uu___.x; y = new_y; z = uu___.z}); radius = c.radius})


let moveUp : circle  ->  Prims.int  ->  circle = (fun ( c  :  circle ) ( offset_y  :  Prims.int ) -> (op_String_Assignment c (op_Bar_Dot_Dot center y) ((op_String_Access c (op_Bar_Dot_Dot center y)) + offset_y)))

type rgb =
{red : Prims.nat; green : Prims.nat; blue : Prims.nat}


let __proj__Mkrgb__item__red : rgb  ->  Prims.nat = (fun ( projectee  :  rgb ) -> (match (projectee) with
| {red = red; green = green; blue = blue} -> begin
red
end))


let __proj__Mkrgb__item__green : rgb  ->  Prims.nat = (fun ( projectee  :  rgb ) -> (match (projectee) with
| {red = red; green = green; blue = blue} -> begin
green
end))


let __proj__Mkrgb__item__blue : rgb  ->  Prims.nat = (fun ( projectee  :  rgb ) -> (match (projectee) with
| {red = red; green = green; blue = blue} -> begin
blue
end))


let red : (rgb, Prims.nat) lens = {get = (fun ( p  :  rgb ) -> p.red); put = (fun ( z1  :  Prims.nat ) ( p  :  rgb ) -> {red = z1; green = p.green; blue = p.blue})}


let green : (rgb, Prims.nat) lens = {get = (fun ( p  :  rgb ) -> p.green); put = (fun ( z1  :  Prims.nat ) ( p  :  rgb ) -> {red = p.red; green = z1; blue = p.blue})}


let blue : (rgb, Prims.nat) lens = {get = (fun ( p  :  rgb ) -> p.blue); put = (fun ( z1  :  Prims.nat ) ( p  :  rgb ) -> {red = p.red; green = p.green; blue = z1})}

type 'a colored =
{color : rgb; payload : 'a}


let __proj__Mkcolored__item__color = (fun ( projectee  :  'a colored ) -> (match (projectee) with
| {color = color; payload = payload} -> begin
color
end))


let __proj__Mkcolored__item__payload = (fun ( projectee  :  'a colored ) -> (match (projectee) with
| {color = color; payload = payload} -> begin
payload
end))


let color = (fun ( uu___  :  unit ) -> {get = (fun ( p  :  'a colored ) -> p.color); put = (fun ( z1  :  rgb ) ( p  :  'a colored ) -> {color = z1; payload = p.payload})})


let payload = (fun ( uu___  :  unit ) -> {get = (fun ( p  :  'a colored ) -> p.payload); put = (fun ( z1  :  'a ) ( p  :  'a colored ) -> {color = p.color; payload = z1})})


let moveUp' : circle colored  ->  Prims.int  ->  circle colored = (fun ( c  :  circle colored ) ( offset_y  :  Prims.int ) -> (op_String_Assignment c (op_Bar_Dot_Dot (op_Bar_Dot_Dot (payload ()) center) y) ((op_String_Access c (op_Bar_Dot_Dot (op_Bar_Dot_Dot (payload ()) center) y)) + offset_y)))


let op_Bar_Bar = (fun ( l1  :  ('a, 'b) lens ) ( l2  :  ('a, 'c) lens ) -> {get = (fun ( a1  :  'a ) -> (((l1.get a1)), ((l2.get a1)))); put = (fun ( uu___  :  ('b * 'c) ) ( a1  :  'a ) -> (match (uu___) with
| (b1, c1) -> begin
(l2.put c1 (l1.put b1 a1))
end))})


let makeGreen : circle colored  ->  circle colored = (fun ( c  :  circle colored ) -> (op_String_Assignment c (op_Bar_Dot_Dot (color ()) (op_Bar_Bar (op_Bar_Bar red green) blue)) (((((Prims.parse_int "0")), ((Prims.parse_int "1")))), ((Prims.parse_int "0")))))

type ('a, 'b, 'l) stlens =
{st_get : 'a FStar_ST.ref  ->  'b; st_put : 'b  ->  'a FStar_ST.ref  ->  'a FStar_ST.ref}


let __proj__Mkstlens__item__st_get = (fun ( l  :  ('a, 'b) lens ) ( projectee  :  ('a, 'b, obj) stlens ) -> (match (projectee) with
| {st_get = st_get; st_put = st_put} -> begin
st_get
end))


let __proj__Mkstlens__item__st_put = (fun ( l  :  ('a, 'b) lens ) ( projectee  :  ('a, 'b, obj) stlens ) -> (match (projectee) with
| {st_get = st_get; st_put = st_put} -> begin
st_put
end))


let st = (fun ( l  :  ('a, 'b) lens ) -> {st_get = (fun ( r  :  'a FStar_ST.ref ) -> (

let uu___ = (FStar_Ref.op_Bang r)
in (op_String_Access uu___ l))); st_put = (fun ( x1  :  'b ) ( r  :  'a FStar_ST.ref ) -> ((

let uu___1 = (

let uu___2 = (FStar_Ref.op_Bang r)
in (op_String_Assignment uu___2 l x1))
in (FStar_Ref.op_Colon_Equals r uu___1));
r;
))})


let op_Bar_Colon_Dot_Dot = (fun ( l  :  ('a, 'b) lens ) ( sl  :  ('a, 'b, obj) stlens ) ( m  :  ('b, 'c) lens ) -> {st_get = (fun ( r  :  'a FStar_ST.ref ) -> (

let uu___ = (sl.st_get r)
in (op_String_Access uu___ m))); st_put = (fun ( x1  :  'c ) ( r  :  'a FStar_ST.ref ) -> (

let uu___ = (

let uu___1 = (sl.st_get r)
in (op_String_Assignment uu___1 m x1))
in (sl.st_put uu___ r)))})


let op_Bar_Colon_Dot = (fun ( l  :  ('a, 'b) lens ) ( x1  :  'a FStar_ST.ref ) ( s  :  ('a, 'b, obj) stlens ) -> (s.st_get x1))


let op_Bar_Colon_Colon_Equals = (fun ( l  :  ('a, 'b) lens ) ( x1  :  'a FStar_ST.ref ) ( s  :  ('a, 'b, obj) stlens ) ( y1  :  'b ) -> (s.st_put y1 x1))


let op_Array_Assignment = (fun ( x1  :  'a FStar_ST.ref ) ( m  :  ('a, 'b) lens ) ( y1  :  'b ) -> (

let uu___ = (op_Bar_Colon_Colon_Equals m x1 (st m) y1)
in ()))


let op_Array_Access = (fun ( x1  :  'a FStar_ST.ref ) ( m  :  ('a, 'b) lens ) -> (op_Bar_Colon_Dot m x1 (st m)))


let mutate : circle colored FStar_ST.ref  ->  unit = (fun ( c  :  circle colored FStar_ST.ref ) -> (op_Array_Assignment c (op_Bar_Dot_Dot (color ()) (op_Bar_Bar (op_Bar_Bar red green) blue)) (((((Prims.parse_int "0")), ((Prims.parse_int "1")))), ((Prims.parse_int "2")))))


let mutate2 : circle FStar_ST.ref colored FStar_ST.ref  ->  unit = (fun ( c  :  circle FStar_ST.ref colored FStar_ST.ref ) -> ((op_Array_Assignment c (op_Bar_Dot_Dot (color ()) (op_Bar_Bar (op_Bar_Bar red green) blue)) (((((Prims.parse_int "0")), ((Prims.parse_int "1")))), ((Prims.parse_int "2"))));
(

let uu___1 = (op_Array_Access c (payload ()))
in (op_Array_Assignment uu___1 (op_Bar_Dot_Dot center x) (Prims.parse_int "17")));
))


let mutate3 : circle FStar_ST.ref colored FStar_ST.ref colored FStar_ST.ref  ->  unit = (fun ( c  :  circle FStar_ST.ref colored FStar_ST.ref colored FStar_ST.ref ) -> (

let uu___ = (

let uu___1 = (op_Array_Access c (payload ()))
in (op_Array_Access uu___1 (payload ())))
in (op_Array_Assignment uu___ (op_Bar_Dot_Dot center x) (Prims.parse_int "17"))))




