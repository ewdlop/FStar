#light "off"
module FStar_RBSet
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

type 'a t =
| L
| N of (color * 'a t * 'a * 'a t)


let uu___is_L = (fun ( projectee  :  'a t ) -> (match (projectee) with
| L -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_N = (fun ( projectee  :  'a t ) -> (match (projectee) with
| N (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__N__item___0 = (fun ( projectee  :  'a t ) -> (match (projectee) with
| N (_0) -> begin
_0
end))


let empty = (fun ( uu___  :  unit ) -> L)


let singleton = (fun ( x  :  'a ) -> N (((R), (L), (x), (L))))


let is_empty = uu___is_L


let balance = (fun ( c  :  color ) ( l  :  'uuuuu t ) ( x  :  'uuuuu ) ( r  :  'uuuuu t ) -> (match (((c), (l), (x), (r))) with
| (B, N (R, N (R, a, x1, b), y, c1), z, d) -> begin
N (((R), (N (((B), (a), (x1), (b)))), (y), (N (((B), (c1), (z), (d))))))
end
| (B, a, x1, N (R, N (R, b, y, c1), z, d)) -> begin
N (((R), (N (((B), (a), (x1), (b)))), (y), (N (((B), (c1), (z), (d))))))
end
| (B, N (R, a, x1, N (R, b, y, c1)), z, d) -> begin
N (((R), (N (((B), (a), (x1), (b)))), (y), (N (((B), (c1), (z), (d))))))
end
| (B, a, x1, N (R, b, y, N (R, c1, z, d))) -> begin
N (((R), (N (((B), (a), (x1), (b)))), (y), (N (((B), (c1), (z), (d))))))
end
| (c1, l1, x1, r1) -> begin
N (((c1), (l1), (x1), (r1)))
end))


let blackroot = (fun ( s  :  'a t ) -> (match (s) with
| N (uu___, l, x, r) -> begin
N (((B), (l), (x), (r)))
end))


let add = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( x  :  'a ) ( s  :  'a t ) -> (

let rec add' : 'a t  ->  'a t = (fun ( s1  :  'a t ) -> (match (s1) with
| L -> begin
N (((R), (L), (x), (L)))
end
| N (c, a1, y, b) -> begin
(match ((FStar_Class_Ord_Raw.op_Less_Question uu___ x y)) with
| true -> begin
(balance c (add' a1) y b)
end
| uu___1 -> begin
(match ((FStar_Class_Ord_Raw.op_Greater_Question uu___ x y)) with
| true -> begin
(balance c a1 y (add' b))
end
| uu___2 -> begin
s1
end)
end)
end))
in (blackroot (add' s))))


let filter = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( predicate  :  'a  ->  Prims.bool ) ( set  :  'a t ) -> (

let rec aux : 'a t  ->  'a t  ->  'a t = (fun ( acc  :  'a t ) ( s  :  'a t ) -> (match (s) with
| L -> begin
acc
end
| N (uu___1, l, v, r) -> begin
(aux (aux (match ((predicate v)) with
| true -> begin
(add uu___ v acc)
end
| uu___2 -> begin
acc
end) l) r)
end))
in (aux (empty ()) set)))


let rec extract_min = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( s  :  'a t ) -> (match (s) with
| N (uu___1, L, x, r) -> begin
((r), (x))
end
| N (c, a1, x, b) -> begin
(

let uu___1 = (extract_min uu___ a1)
in (match (uu___1) with
| (a', y) -> begin
(((balance c a' x b)), (y))
end))
end))


let rec remove = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( x  :  'a ) ( s  :  'a t ) -> (match (s) with
| L -> begin
L
end
| N (c, l, y, r) -> begin
(match ((FStar_Class_Ord_Raw.op_Less_Question uu___ x y)) with
| true -> begin
(balance c (remove uu___ x l) y r)
end
| uu___1 -> begin
(match ((FStar_Class_Ord_Raw.op_Greater_Question uu___ x y)) with
| true -> begin
(balance c l y (remove uu___ x r))
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
| (r', y') -> begin
(balance c l y' r')
end))
end)
end)
end)
end))


let rec mem = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( x  :  'a ) ( s  :  'a t ) -> (match (s) with
| L -> begin
false
end
| N (uu___1, a1, y, b) -> begin
(match ((FStar_Class_Ord_Raw.op_Less_Question uu___ x y)) with
| true -> begin
(mem uu___ x a1)
end
| uu___2 -> begin
(match ((FStar_Class_Ord_Raw.op_Greater_Question uu___ x y)) with
| true -> begin
(mem uu___ x b)
end
| uu___3 -> begin
true
end)
end)
end))


let rec elems = (fun ( s  :  'a t ) -> (match (s) with
| L -> begin
[]
end
| N (uu___, a1, x, b) -> begin
(FStar_List_Tot_Base.op_At (elems a1) (FStar_List_Tot_Base.op_At ((x)::[]) (elems b)))
end))


let equal = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( s1  :  'a t ) ( s2  :  'a t ) -> (FStar_Class_Eq_Raw.op_Equals (FStar_Class_Ord_Raw.ord_eq (FStar_Class_Ord_Raw.ord_list uu___)) (elems s1) (elems s2)))


let rec union = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( s1  :  'a t ) ( s2  :  'a t ) -> (match (s1) with
| L -> begin
s2
end
| N (c, a1, x, b) -> begin
(union uu___ a1 (union uu___ b (add uu___ x s2)))
end))


let inter = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( s1  :  'a t ) ( s2  :  'a t ) -> (

let rec aux : 'a t  ->  'a t  ->  'a t = (fun ( s11  :  'a t ) ( acc  :  'a t ) -> (match (s11) with
| L -> begin
acc
end
| N (uu___1, a1, x, b) -> begin
(match ((mem uu___ x s2)) with
| true -> begin
(add uu___ x (aux a1 (aux b acc)))
end
| uu___2 -> begin
(aux a1 (aux b acc))
end)
end))
in (aux s1 L)))


let rec diff = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( s1  :  'a t ) ( s2  :  'a t ) -> (match (s2) with
| L -> begin
s1
end
| N (uu___1, a1, x, b) -> begin
(diff uu___ (diff uu___ (remove uu___ x s1) a1) b)
end))


let rec subset = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( s1  :  'a t ) ( s2  :  'a t ) -> (match (s1) with
| L -> begin
true
end
| N (uu___1, a1, x, b) -> begin
(((mem uu___ x s2) && (subset uu___ a1 s2)) && (subset uu___ b s2))
end))


let rec for_all = (fun ( p  :  'a  ->  Prims.bool ) ( s  :  'a t ) -> (match (s) with
| L -> begin
true
end
| N (uu___, a1, x, b) -> begin
(((p x) && (for_all p a1)) && (for_all p b))
end))


let rec for_any = (fun ( p  :  'a  ->  Prims.bool ) ( s  :  'a t ) -> (match (s) with
| L -> begin
false
end
| N (uu___, a1, x, b) -> begin
(((p x) || (for_any p a1)) || (for_any p b))
end))


let from_list = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( xs  :  'a Prims.list ) -> (FStar_List_Tot_Base.fold_left (fun ( s  :  'a t ) ( e  :  'a ) -> (add uu___ e s)) L xs))


let addn = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( xs  :  'a Prims.list ) ( s  :  'a t ) -> (FStar_List_Tot_Base.fold_left (fun ( s1  :  'a t ) ( e  :  'a ) -> (add uu___ e s1)) s xs))


let collect = (fun ( uu___  :  'a FStar_Class_Ord_Raw.ord ) ( f  :  'a  ->  'a t ) ( l  :  'a Prims.list ) -> (FStar_List_Tot_Base.fold_left (fun ( s  :  'a t ) ( e  :  'a ) -> (union uu___ (f e) s)) L l))




