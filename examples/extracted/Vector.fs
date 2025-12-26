#light "off"
module Vector
type ('a, 'dummyV0) vector =
| VNil
| VCons of 'a * Prims.nat * ('a, obj) vector


let uu___is_VNil = (fun ( uu___  :  Prims.nat ) ( projectee  :  ('a, obj) vector ) -> (match (projectee) with
| VNil -> begin
true
end
| uu___1 -> begin
false
end))


let uu___is_VCons = (fun ( uu___  :  Prims.nat ) ( projectee  :  ('a, obj) vector ) -> (match (projectee) with
| VCons (hd, n, tl) -> begin
true
end
| uu___1 -> begin
false
end))


let __proj__VCons__item__hd = (fun ( uu___  :  Prims.nat ) ( projectee  :  ('a, obj) vector ) -> (match (projectee) with
| VCons (hd, n, tl) -> begin
hd
end))


let __proj__VCons__item__n = (fun ( uu___  :  Prims.nat ) ( projectee  :  ('a, obj) vector ) -> (match (projectee) with
| VCons (hd, n, tl) -> begin
n
end))


let __proj__VCons__item__tl = (fun ( uu___  :  Prims.nat ) ( projectee  :  ('a, obj) vector ) -> (match (projectee) with
| VCons (hd, n, tl) -> begin
tl
end))


let head = (fun ( n  :  Prims.pos ) ( v  :  ('a, obj) vector ) -> (match (v) with
| VCons (x, uu___, xs) -> begin
x
end))


let rec nth = (fun ( n  :  Prims.nat ) ( m  :  Prims.nat ) ( uu___  :  ('a, obj) vector ) -> (match (uu___) with
| VCons (x, m', xs) -> begin
(match ((Prims.op_Equality n (Prims.parse_int "0"))) with
| true -> begin
x
end
| uu___1 -> begin
(nth (n - (Prims.parse_int "1")) m' xs)
end)
end))


let rec append = (fun ( n1  :  Prims.nat ) ( n2  :  Prims.nat ) ( v1  :  ('a, obj) vector ) ( v2  :  ('a, obj) vector ) -> (match (v1) with
| VNil -> begin
v2
end
| VCons (hd, uu___, tl) -> begin
VCons (hd, (uu___ + n2), (append uu___ n2 tl v2))
end))


let rec reverse = (fun ( n  :  Prims.nat ) ( v  :  ('a, obj) vector ) -> (match (v) with
| VNil -> begin
VNil
end
| VCons (hd, uu___, tl) -> begin
(append uu___ (Prims.parse_int "1") (reverse uu___ tl) (VCons (hd, (Prims.parse_int "0"), VNil)))
end))


let rec mapT = (fun ( f  :  'a  ->  'b ) ( n  :  Prims.nat ) ( v  :  ('a, obj) vector ) -> (match (v) with
| VNil -> begin
VNil
end
| VCons (hd, uu___, tl) -> begin
VCons ((f hd), uu___, (mapT f uu___ tl))
end))


let rec fold_left = (fun ( f  :  'b  ->  'a  ->  'b ) ( acc  :  'b ) ( n  :  Prims.nat ) ( v  :  ('a, obj) vector ) -> (match (v) with
| VNil -> begin
acc
end
| VCons (hd, uu___, tl) -> begin
(fold_left f (f acc hd) uu___ tl)
end))


let rec fold_right = (fun ( f  :  'a  ->  'b  ->  'b ) ( n  :  Prims.nat ) ( v  :  ('a, obj) vector ) ( acc  :  'b ) -> (match (v) with
| VNil -> begin
acc
end
| VCons (hd, uu___, tl) -> begin
(f hd (fold_right f uu___ tl acc))
end))


let rec find = (fun ( f  :  'a  ->  Prims.bool ) ( n  :  Prims.nat ) ( v  :  ('a, obj) vector ) -> (match (v) with
| VNil -> begin
FStar_Pervasives_Native.None
end
| VCons (hd, uu___, tl) -> begin
(match ((f hd)) with
| true -> begin
FStar_Pervasives_Native.Some (hd)
end
| uu___1 -> begin
(find f uu___ tl)
end)
end))


let rec zip' = (fun ( n  :  Prims.nat ) ( v1  :  ('a, obj) vector ) ( v2  :  ('b, obj) vector ) -> (match (v1) with
| VNil -> begin
VNil
end
| VCons (a1, uu___, tl1) -> begin
(

let uu___1 = v2
in (match (uu___1) with
| VCons (b1, uu___2, tl2) -> begin
VCons (((a1), (b1)), uu___, (zip' uu___ tl1 tl2))
end))
end))




