#light "off"
module FStar_OrdSet

type total_order =
unit


type 'a cmp =
'a  ->  'a  ->  Prims.bool


let rec sorted = (fun ( f  :  'a cmp ) ( l  :  'a Prims.list ) -> (match (l) with
| [] -> begin
true
end
| (x)::[] -> begin
true
end
| (x)::(y)::tl -> begin
(((f x y) && (Prims.op_disEquality x y)) && (sorted f ((y)::tl)))
end))



let empty = (fun ( uu___  :  'uuuuu cmp ) -> [])


let tail = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (Prims.__proj__Cons__item__tl s))


let head = (fun ( uu___  :  'uuuuu cmp ) ( s  :  ('uuuuu, obj) ordset ) -> (Prims.__proj__Cons__item__hd s))


let mem = (fun ( uu___  :  'uuuuu cmp ) ( x  :  'uuuuu ) ( s  :  ('uuuuu, obj) ordset ) -> (FStar_List_Tot_Base.mem x s))


let mem_of = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) ( x  :  'a ) -> (mem f x s))


let rec last_direct = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (match (s) with
| (x)::[] -> begin
x
end
| (h)::(g)::t -> begin
(last_direct f (tail f s))
end))


let last_lib = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (FStar_Pervasives_Native.snd (FStar_List_Tot_Base.unsnoc s)))


let last = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (last_lib f s))


let rec liat_direct = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (match (s) with
| (x)::[] -> begin
[]
end
| (h)::(g)::t -> begin
(h)::(liat_direct f ((g)::t))
end))


let liat_lib = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (FStar_Pervasives_Native.fst (FStar_List_Tot_Base.unsnoc s)))


let liat = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (liat_lib f s))


let unsnoc = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (

let l = (FStar_List_Tot_Base.unsnoc s)
in (((FStar_Pervasives_Native.fst l)), ((FStar_Pervasives_Native.snd l)))))


let as_list = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> s)


let rec insert' = (fun ( f  :  'uuuuu cmp ) ( x  :  'uuuuu ) ( s  :  ('uuuuu, obj) ordset ) -> (match (s) with
| [] -> begin
(x)::[]
end
| (hd)::tl -> begin
(match ((Prims.op_Equality x hd)) with
| true -> begin
(hd)::tl
end
| uu___ -> begin
(match ((f x hd)) with
| true -> begin
(x)::(hd)::tl
end
| uu___1 -> begin
(hd)::(insert' f x tl)
end)
end)
end))


let rec distinct' = (fun ( f  :  'a cmp ) ( l  :  'a Prims.list ) -> (match (l) with
| [] -> begin
[]
end
| (x)::t -> begin
(insert' f x (distinct' f t))
end))


let distinct = (fun ( f  :  'a cmp ) ( l  :  'a Prims.list ) -> (distinct' f l))


let rec union = (fun ( uu___  :  'uuuuu cmp ) ( s1  :  ('uuuuu, obj) ordset ) ( s2  :  ('uuuuu, obj) ordset ) -> (match (s1) with
| [] -> begin
s2
end
| (hd)::tl -> begin
(union uu___ tl (insert' uu___ hd s2))
end))


let rec remove' = (fun ( f  :  'a cmp ) ( x  :  'a ) ( s  :  ('a, obj) ordset ) -> (match (s) with
| [] -> begin
[]
end
| (hd)::tl -> begin
(

let tl1 = tl
in (match ((Prims.op_Equality x hd)) with
| true -> begin
tl1
end
| uu___ -> begin
(hd)::(remove' f x tl1)
end))
end))


let size' = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (FStar_List_Tot_Base.length s))


let rec subset' = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> (match (((s1), (s2))) with
| ([], uu___) -> begin
true
end
| ((hd)::tl, (hd')::tl') -> begin
(match (((f hd hd') && (Prims.op_Equality hd hd'))) with
| true -> begin
(subset' f tl tl')
end
| uu___ -> begin
(match (((f hd hd') && (not ((Prims.op_Equality hd hd'))))) with
| true -> begin
false
end
| uu___1 -> begin
(subset' f s1 tl')
end)
end)
end
| (uu___, uu___1) -> begin
false
end))


let rec remove_until_greater_than = (fun ( f  :  'a cmp ) ( x  :  'a ) ( s  :  ('a, obj) ordset ) -> (match (s) with
| [] -> begin
(([]), (false))
end
| (h)::t -> begin
(

let t1 = t
in (match ((Prims.op_Equality h x)) with
| true -> begin
((t1), (true))
end
| uu___ -> begin
(match ((f x h)) with
| true -> begin
((s), (false))
end
| uu___1 -> begin
(remove_until_greater_than f x t1)
end)
end))
end))


let rec smart_intersect = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> (match (s1) with
| [] -> begin
[]
end
| (h1)::t1 -> begin
(

let t11 = t1
in (match (s2) with
| [] -> begin
[]
end
| (h2)::t2 -> begin
(

let t21 = t2
in (match ((Prims.op_Equality h1 h2)) with
| true -> begin
(h1)::(smart_intersect f t11 t21)
end
| uu___ -> begin
(match ((f h1 h2)) with
| true -> begin
(

let uu___1 = (remove_until_greater_than f h2 t11)
in (match (uu___1) with
| (skip1, found) -> begin
(

let subresult = (smart_intersect f skip1 t21)
in (match (found) with
| true -> begin
(h2)::subresult
end
| uu___2 -> begin
subresult
end))
end))
end
| uu___1 -> begin
(

let uu___2 = (remove_until_greater_than f h1 t21)
in (match (uu___2) with
| (skip2, found) -> begin
(

let subresult = (smart_intersect f t11 skip2)
in (match (found) with
| true -> begin
(h1)::subresult
end
| uu___3 -> begin
subresult
end))
end))
end)
end))
end))
end))


let intersect = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> (smart_intersect f s1 s2))


let choose = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (match (s) with
| [] -> begin
FStar_Pervasives_Native.None
end
| (x)::uu___ -> begin
FStar_Pervasives_Native.Some (x)
end))


let remove = (fun ( f  :  'a cmp ) ( x  :  'a ) ( s  :  ('a, obj) ordset ) -> (remove' f x s))


let size = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (size' f s))


let subset = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> (subset' f s1 s2))


let superset = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> (subset f s2 s1))


let singleton = (fun ( f  :  'a cmp ) ( x  :  'a ) -> (x)::[])


let rec smart_minus = (fun ( f  :  'a cmp ) ( p  :  ('a, obj) ordset ) ( q  :  ('a, obj) ordset ) -> (match (p) with
| [] -> begin
[]
end
| (ph)::pt -> begin
(

let pt1 = pt
in (match (q) with
| [] -> begin
p
end
| (qh)::qt -> begin
(

let qt1 = qt
in (

let uu___ = (remove_until_greater_than f ph q)
in (match (uu___) with
| (q_after_ph, found) -> begin
(match (found) with
| true -> begin
(

let result = (smart_minus f pt1 q_after_ph)
in result)
end
| uu___1 -> begin
(ph)::(smart_minus f pt1 q_after_ph)
end)
end)))
end))
end))


let ncmp : Prims.nat  ->  Prims.nat  ->  Prims.bool = (fun ( x  :  Prims.nat ) ( y  :  Prims.nat ) -> (x <= y))


let minus = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> (smart_minus f s1 s2))


let strict_subset = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> ((Prims.op_disEquality s1 s2) && (subset f s1 s2)))


let strict_superset = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> (strict_subset f s2 s1))


let disjoint = (fun ( f  :  'a cmp ) ( s1  :  ('a, obj) ordset ) ( s2  :  ('a, obj) ordset ) -> (Prims.op_Equality (intersect f s1 s2) (empty f)))


type equal =
unit


let fold = (fun ( f  :  'a cmp ) ( g  :  'acc  ->  'a  ->  'acc ) ( init  :  'acc ) ( s  :  ('a, obj) ordset ) -> (FStar_List_Tot_Base.fold_left g init s))


let rec map_internal = (fun ( fa  :  'a cmp ) ( fb  :  'b cmp ) ( g  :  'a  ->  'b ) ( sa  :  ('a, obj) ordset ) -> (match (sa) with
| [] -> begin
[]
end
| (x)::xs -> begin
(

let y = (g x)
in (

let ys = (map_internal fa fb g xs)
in (match (((not ((Prims.uu___is_Cons ys))) || (Prims.op_disEquality (Prims.__proj__Cons__item__hd ys) y))) with
| true -> begin
(y)::ys
end
| uu___ -> begin
ys
end)))
end))


let map = (fun ( fa  :  'a cmp ) ( fb  :  'b cmp ) ( g  :  'a  ->  'b ) ( sa  :  ('a, obj) ordset ) -> (map_internal fa fb g sa))


type 'a condition =
'a  ->  Prims.bool


let inv = (fun ( c  :  'a condition ) ( x  :  'a ) -> (not ((c x))))


let rec count = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) ( c  :  'a condition ) -> (match (s) with
| [] -> begin
(Prims.parse_int "0")
end
| (h)::t -> begin
(match ((c h)) with
| true -> begin
((Prims.parse_int "1") + (count f t c))
end
| uu___ -> begin
(count f t c)
end)
end))


let rec all = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) ( c  :  'a condition ) -> (match (s) with
| [] -> begin
true
end
| (h)::t -> begin
((c h) && (all f t c))
end))


let rec any = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) ( c  :  'a condition ) -> (match (s) with
| [] -> begin
false
end
| (h)::t -> begin
((c h) || (any f t c))
end))


let rec find_first = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) ( c  :  'a condition ) -> (match (s) with
| [] -> begin
FStar_Pervasives_Native.None
end
| (h)::t -> begin
(

let t1 = t
in (match ((c h)) with
| true -> begin
FStar_Pervasives_Native.Some (h)
end
| uu___ -> begin
(find_first f t1 c)
end))
end))


let rec find_last' = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) ( c  :  'a condition ) -> (match ((Prims.op_Equality s (empty f))) with
| true -> begin
FStar_Pervasives_Native.None
end
| uu___ -> begin
(

let uu___1 = (unsnoc f s)
in (match (uu___1) with
| (liat1, last1) -> begin
(match ((c last1)) with
| true -> begin
FStar_Pervasives_Native.Some (last1)
end
| uu___2 -> begin
(find_last' f liat1 c)
end)
end))
end))


let find_last = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) ( c  :  'a condition ) -> (find_last' f s c))


let rec where = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) ( c  :  'a condition ) -> (match (s) with
| [] -> begin
[]
end
| (h)::[] -> begin
(match ((c h)) with
| true -> begin
(h)::[]
end
| uu___ -> begin
[]
end)
end
| (h)::t -> begin
(

let t1 = t
in (match ((c h)) with
| true -> begin
(h)::(where f t1 c)
end
| uu___ -> begin
(where f t1 c)
end))
end))


let rec as_set = (fun ( f  :  'a cmp ) ( s  :  ('a, obj) ordset ) -> (match (s) with
| [] -> begin
(FStar_Set.empty ())
end
| (hd)::tl -> begin
(FStar_Set.union (FStar_Set.singleton hd) (as_set f tl))
end))




