#light "off"
module FStar_RBMap
type color =
| R
| B


let uu___is_R : color  ->  Prims.bool = (fun ( projectee  :  color ) -> (match (projectee) with
| R -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_B : color  ->  Prims.bool = (fun ( projectee  :  color ) -> (match (projectee) with
| B -> begin
true
end
| uu___ -> begin
false
end))

type ('a, 'b) t =
| L
| N of (color * ('a, 'b) t * 'a * 'b * ('a, 'b) t)


let uu___is_L = (fun ( projectee  :  ('a, 'b) t ) -> (match (projectee) with
| L -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_N = (fun ( projectee  :  ('a, 'b) t ) -> (match (projectee) with
| N (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__N__item___0 = (fun ( projectee  :  ('a, 'b) t ) -> (match (projectee) with
| N (_0) -> begin
_0
end))


let empty = (fun ( uu___  :  unit ) -> L)


let singleton = (fun ( x  :  'a ) ( y  :  'b ) -> N (((R), (L), (x), (y), (L))))


let is_empty = uu___is_L


let balance = (fun ( c  :  color ) ( l  :  ('uuuuu, 'uuuuu1) t ) ( x  :  'uuuuu ) ( vx  :  'uuuuu1 ) ( r  :  ('uuuuu, 'uuuuu1) t ) -> (match (((c), (l), (x), (vx), (r))) with
| (B, N (R, N (R, a, x1, vx1, b), y, vy, c1), z, vz, d) -> begin
N (((R), (N (((B), (a), (x1), (vx1), (b)))), (y), (vy), (N (((B), (c1), (z), (vz), (d))))))
end
| (B, a, x1, vx1, N (R, N (R, b, y, vy, c1), z, vz, d)) -> begin
N (((R), (N (((B), (a), (x1), (vx1), (b)))), (y), (vy), (N (((B), (c1), (z), (vz), (d))))))
end
| (B, N (R, a, x1, vx1, N (R, b, y, vy, c1)), z, vz, d) -> begin
N (((R), (N (((B), (a), (x1), (vx1), (b)))), (y), (vy), (N (((B), (c1), (z), (vz), (d))))))
end
| (B, a, x1, vx1, N (R, b, y, vy, N (R, c1, z, vz, d))) -> begin
N (((R), (N (((B), (a), (x1), (vx1), (b)))), (y), (vy), (N (((B), (c1), (z), (vz), (d))))))
end
| (c1, l1, x1, vx1, r1) -> begin
N (((c1), (l1), (x1), (vx1), (r1)))
end))


let blackroot = (fun ( m  :  ('a, 'b) t ) -> (

let uu___ = m
in (match (uu___) with
| N (uu___1, l, x, vx, r) -> begin
N (((B), (l), (x), (vx), (r)))
end)))


let add = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( x  :  'a ) ( vx  :  'b ) ( s  :  ('a, 'b) t ) -> (

let rec add' : ('a, 'b) t  ->  ('a, 'b) t = (fun ( s1  :  ('a, 'b) t ) -> (match (s1) with
| L -> begin
N (((R), (L), (x), (vx), (L)))
end
| N (c, a1, y, vy, b1) -> begin
(match ((FStar_Class_Ord_Raw.op_Less_Question uu___ x y)) with
| true -> begin
(balance c (add' a1) y vy b1)
end
| uu___1 -> begin
(match ((FStar_Class_Ord_Raw.op_Greater_Question uu___ x y)) with
| true -> begin
(balance c a1 y vy (add' b1))
end
| uu___2 -> begin
s1
end)
end)
end))
in (blackroot (add' s))))


let filter = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( predicate  :  'a  ->  'b  ->  Prims.bool ) ( set  :  ('a, 'b) t ) -> (

let rec aux : ('a, 'b) t  ->  ('a, 'b) t  ->  ('a, 'b) t = (fun ( acc  :  ('a, 'b) t ) ( m  :  ('a, 'b) t ) -> (match (m) with
| L -> begin
acc
end
| N (uu___1, l, v, vy, r) -> begin
(aux (aux (match ((predicate v vy)) with
| true -> begin
(add uu___ v vy acc)
end
| uu___2 -> begin
acc
end) l) r)
end))
in (aux (empty ()) set)))


let rec extract_min = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( m  :  ('a, 'b) t ) -> (match (m) with
| N (uu___1, L, x, vx, r) -> begin
((r), (((x), (vx))))
end
| N (c, a1, x, vx, b1) -> begin
(

let uu___1 = (extract_min uu___ a1)
in (match (uu___1) with
| (a', y) -> begin
(((balance c a' x vx b1)), (y))
end))
end))


let rec remove = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( x  :  'a ) ( m  :  ('a, 'b) t ) -> (match (m) with
| L -> begin
L
end
| N (c, l, y, vy, r) -> begin
(match ((FStar_Class_Ord_Raw.op_Less_Question uu___ x y)) with
| true -> begin
(balance c (remove uu___ x l) y vy r)
end
| uu___1 -> begin
(match ((FStar_Class_Ord_Raw.op_Greater_Question uu___ x y)) with
| true -> begin
(balance c l y vy (remove uu___ x r))
end
| uu___2 -> begin
(match ((uu___is_L r)) with
| true -> begin
l
end
| uu___3 -> begin
(

let uu___4 = (extract_min uu___ r)
in (match (uu___4) with
| (r', (y', vy')) -> begin
(balance c l y' vy' r')
end))
end)
end)
end)
end))


let rec mem = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( x  :  'a ) ( m  :  ('a, 'b) t ) -> (match (m) with
| L -> begin
false
end
| N (uu___1, a1, y, uu___2, b1) -> begin
(match ((FStar_Class_Ord_Raw.op_Less_Question uu___ x y)) with
| true -> begin
(mem uu___ x a1)
end
| uu___3 -> begin
(match ((FStar_Class_Ord_Raw.op_Greater_Question uu___ x y)) with
| true -> begin
(mem uu___ x b1)
end
| uu___4 -> begin
true
end)
end)
end))


let rec lookup = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( x  :  'a ) ( m  :  ('a, 'b) t ) -> (match (m) with
| L -> begin
FStar_Pervasives_Native.None
end
| N (uu___1, a1, y, vy, b1) -> begin
(match ((FStar_Class_Ord_Raw.op_Less_Question uu___ x y)) with
| true -> begin
(lookup uu___ x a1)
end
| uu___2 -> begin
(match ((FStar_Class_Ord_Raw.op_Greater_Question uu___ x y)) with
| true -> begin
(lookup uu___ x b1)
end
| uu___3 -> begin
FStar_Pervasives_Native.Some (vy)
end)
end)
end))


let rec keys = (fun ( s  :  ('a, 'b) t ) -> (match (s) with
| L -> begin
[]
end
| N (uu___, a1, x, uu___1, b1) -> begin
(FStar_List_Tot_Base.op_At (keys a1) (FStar_List_Tot_Base.op_At ((x)::[]) (keys b1)))
end))


let rec to_list = (fun ( s  :  ('a, 'b) t ) -> (match (s) with
| L -> begin
[]
end
| N (uu___, a1, x, vx, b1) -> begin
(FStar_List_Tot_Base.op_At (to_list a1) (FStar_List_Tot_Base.op_At ((((x), (vx)))::[]) (to_list b1)))
end))


let equal = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( uu___1  :  'b FStar_Class_Eq_Raw.deq ) ( s1  :  ('a, 'b) t ) ( s2  :  ('a, 'b) t ) -> (FStar_Class_Eq_Raw.op_Equals (FStar_Class_Eq_Raw.eq_list (FStar_Class_Eq_Raw.eq_pair (FStar_Class_Ord_Raw.ord_eq uu___) uu___1)) (to_list s1) (to_list s2)))


let rec union = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( s1  :  ('a, 'b) t ) ( s2  :  ('a, 'b) t ) -> (match (s1) with
| L -> begin
s2
end
| N (c, a1, x, vx, b1) -> begin
(union uu___ a1 (union uu___ b1 (add uu___ x vx s2)))
end))


let inter = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( s1  :  ('a, 'b) t ) ( s2  :  ('a, 'b) t ) -> (

let rec aux : ('a, 'b) t  ->  ('a, 'b) t  ->  ('a, 'b) t = (fun ( s11  :  ('a, 'b) t ) ( acc  :  ('a, 'b) t ) -> (match (s11) with
| L -> begin
acc
end
| N (uu___1, a1, x, vx, b1) -> begin
(match ((mem uu___ x s2)) with
| true -> begin
(add uu___ x vx (aux a1 (aux b1 acc)))
end
| uu___2 -> begin
(aux a1 (aux b1 acc))
end)
end))
in (aux s1 L)))


let rec for_all = (fun ( p  :  'a  ->  'b  ->  Prims.bool ) ( s  :  ('a, 'b) t ) -> (match (s) with
| L -> begin
true
end
| N (uu___, a1, x, vx, b1) -> begin
(((p x vx) && (for_all p a1)) && (for_all p b1))
end))


let rec for_any = (fun ( p  :  'a  ->  'b  ->  Prims.bool ) ( s  :  ('a, 'b) t ) -> (match (s) with
| L -> begin
false
end
| N (uu___, a1, x, vx, b1) -> begin
((p x vx) || ((for_all p a1) && (for_all p b1)))
end))


let from_list = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( xs  :  ('a * 'b) Prims.list ) -> (FStar_List_Tot_Base.fold_left (fun ( s  :  ('a, 'b) t ) ( uu___1  :  ('a * 'b) ) -> (match (uu___1) with
| (k, v) -> begin
(add uu___ k v s)
end)) L xs))


let addn = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( xs  :  ('a * 'b) Prims.list ) ( s  :  ('a, 'b) t ) -> (FStar_List_Tot_Base.fold_left (fun ( s1  :  ('a, 'b) t ) ( uu___1  :  ('a * 'b) ) -> (match (uu___1) with
| (k, v) -> begin
(add uu___ k v s1)
end)) s xs))




