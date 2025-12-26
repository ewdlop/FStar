#light "off"
module BinomialQueue

type key_t =
Prims.nat

type tree =
| Leaf
| Internal of tree * key_t * tree


let uu___is_Leaf : tree  ->  Prims.bool = (fun ( projectee  :  tree ) -> (match (projectee) with
| Leaf -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Internal : tree  ->  Prims.bool = (fun ( projectee  :  tree ) -> (match (projectee) with
| Internal (_0, _1, _2) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Internal__item___0 : tree  ->  tree = (fun ( projectee  :  tree ) -> (match (projectee) with
| Internal (_0, _1, _2) -> begin
_0
end))


let __proj__Internal__item___1 : tree  ->  key_t = (fun ( projectee  :  tree ) -> (match (projectee) with
| Internal (_0, _1, _2) -> begin
_1
end))


let __proj__Internal__item___2 : tree  ->  tree = (fun ( projectee  :  tree ) -> (match (projectee) with
| Internal (_0, _1, _2) -> begin
_2
end))


type pow2heap_pred =
obj


type is_pow2heap =
obj


type forest =
tree Prims.list


type is_binomial_queue =
obj


type is_compact =
unit


type is_priq =
unit


type priq =
forest


let empty : priq = []


let rec all_leaf : forest  ->  Prims.bool = (fun ( l  :  forest ) -> (match (l) with
| (Leaf)::[] -> begin
true
end
| (Leaf)::tl -> begin
(all_leaf tl)
end
| uu___ -> begin
false
end))


let rec mk_compact : forest  ->  forest = (fun ( l  :  forest ) -> (match (l) with
| [] -> begin
[]
end
| uu___ -> begin
(match ((all_leaf l)) with
| true -> begin
[]
end
| uu___1 -> begin
(

let uu___2 = l
in (match (uu___2) with
| (hd)::tl -> begin
(hd)::(mk_compact tl)
end))
end)
end))


let smash : Prims.pos  ->  tree  ->  tree  ->  tree = (fun ( d  :  Prims.pos ) ( t1  :  tree ) ( t2  :  tree ) -> (match (((t1), (t2))) with
| (Internal (left1, k1, Leaf), Internal (left2, k2, Leaf)) -> begin
(match ((k1 <= k2)) with
| true -> begin
Internal (Internal (left1, k1, left2), k2, Leaf)
end
| uu___ -> begin
Internal (Internal (left2, k2, left1), k1, Leaf)
end)
end))


let rec carry : Prims.pos  ->  forest  ->  tree  ->  forest = (fun ( d  :  Prims.pos ) ( q  :  forest ) ( t  :  tree ) -> (match (q) with
| [] -> begin
(t)::[]
end
| (Leaf)::tl -> begin
(t)::tl
end
| (hd)::tl -> begin
(

let q1 = (carry (d + (Prims.parse_int "1")) tl (smash d hd t))
in (Leaf)::q1)
end))


let rec join : Prims.pos  ->  forest  ->  forest  ->  tree  ->  forest = (fun ( d  :  Prims.pos ) ( p  :  forest ) ( q  :  forest ) ( c  :  tree ) -> (match (((p), (q), (c))) with
| ([], uu___, Leaf) -> begin
q
end
| (uu___, [], Leaf) -> begin
p
end
| ([], uu___, uu___1) -> begin
(carry d q c)
end
| (uu___, [], uu___1) -> begin
(carry d p c)
end
| ((Leaf)::tl_p, (Leaf)::tl_q, uu___) -> begin
(c)::(join (d + (Prims.parse_int "1")) tl_p tl_q Leaf)
end
| ((hd_p)::tl_p, (Leaf)::tl_q, Leaf) -> begin
(hd_p)::(join (d + (Prims.parse_int "1")) tl_p tl_q Leaf)
end
| ((Leaf)::tl_p, (hd_q)::tl_q, Leaf) -> begin
(hd_q)::(join (d + (Prims.parse_int "1")) tl_p tl_q Leaf)
end
| ((Leaf)::tl_p, (hd_q)::tl_q, uu___) -> begin
(Leaf)::(join (d + (Prims.parse_int "1")) tl_p tl_q (smash d hd_q c))
end
| ((hd_p)::tl_p, (Leaf)::tl_q, uu___) -> begin
(Leaf)::(join (d + (Prims.parse_int "1")) tl_p tl_q (smash d hd_p c))
end
| ((hd_p)::tl_p, (hd_q)::tl_q, c1) -> begin
(c1)::(join (d + (Prims.parse_int "1")) tl_p tl_q (smash d hd_p hd_q))
end))


let insert : key_t  ->  priq  ->  priq = (fun ( x  :  key_t ) ( q  :  priq ) -> (

let l = (carry (Prims.parse_int "1") q (Internal (Leaf, x, Leaf)))
in (mk_compact l)))


let rec find_max : key_t FStar_Pervasives_Native.option  ->  forest  ->  key_t FStar_Pervasives_Native.option = (fun ( max  :  key_t FStar_Pervasives_Native.option ) ( q  :  forest ) -> (match (q) with
| [] -> begin
max
end
| (Leaf)::q1 -> begin
(find_max max q1)
end
| (Internal (uu___, k, uu___1))::q1 -> begin
(match (max) with
| FStar_Pervasives_Native.None -> begin
(find_max (FStar_Pervasives_Native.Some (k)) q1)
end
| FStar_Pervasives_Native.Some (max1) -> begin
(find_max (match ((max1 < k)) with
| true -> begin
FStar_Pervasives_Native.Some (k)
end
| uu___2 -> begin
FStar_Pervasives_Native.Some (max1)
end) q1)
end)
end))


let rec unzip : Prims.nat  ->  key_t  ->  tree  ->  priq = (fun ( d  :  Prims.nat ) ( upper_bound  :  key_t ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
[]
end
| Internal (left, k, right) -> begin
(

let q = (unzip (d - (Prims.parse_int "1")) upper_bound right)
in (FStar_List_Tot_Base.append q ((Internal (left, k, Leaf))::[])))
end))


let heap_delete_max : Prims.pos  ->  tree  ->  priq = (fun ( d  :  Prims.pos ) ( t  :  tree ) -> (match (t) with
| Internal (left, k, Leaf) -> begin
(unzip (d - (Prims.parse_int "1")) k left)
end))


let rec delete_max_aux : key_t  ->  Prims.pos  ->  forest  ->  (key_t * forest * priq) = (fun ( m  :  key_t ) ( d  :  Prims.pos ) ( q  :  forest ) -> (match (q) with
| [] -> begin
(((m + (Prims.parse_int "1"))), ([]), ([]))
end
| (Leaf)::q1 -> begin
(

let uu___ = (delete_max_aux m (d + (Prims.parse_int "1")) q1)
in (match (uu___) with
| (x, q2, new_q) -> begin
((x), ((Leaf)::q2), (new_q))
end))
end
| (Internal (left, x, right))::q1 -> begin
(match ((x < m)) with
| true -> begin
(

let uu___ = (delete_max_aux m (d + (Prims.parse_int "1")) q1)
in (match (uu___) with
| (y, q2, new_q) -> begin
((y), ((Internal (left, x, right))::q2), (new_q))
end))
end
| uu___ -> begin
((x), ((Leaf)::q1), ((heap_delete_max d (Internal (left, x, right)))))
end)
end))


let delete_max : priq  ->  (key_t * priq) FStar_Pervasives_Native.option = (fun ( q  :  priq ) -> (match ((find_max FStar_Pervasives_Native.None q)) with
| FStar_Pervasives_Native.None -> begin
FStar_Pervasives_Native.None
end
| FStar_Pervasives_Native.Some (m) -> begin
(

let uu___ = (delete_max_aux m (Prims.parse_int "1") q)
in (match (uu___) with
| (x, q1, new_q) -> begin
(

let r = (join (Prims.parse_int "1") q1 new_q Leaf)
in FStar_Pervasives_Native.Some (((x), ((mk_compact r)))))
end))
end))


let merge : priq  ->  priq  ->  priq = (fun ( p  :  priq ) ( q  :  priq ) -> (

let l = (join (Prims.parse_int "1") p q Leaf)
in (mk_compact l)))

type ms =
{ms_count : key_t  ->  Prims.nat; ms_elems : key_t FStar_Set.set}


let __proj__Mkms__item__ms_count : ms  ->  key_t  ->  Prims.nat = (fun ( projectee  :  ms ) -> (match (projectee) with
| {ms_count = ms_count; ms_elems = ms_elems} -> begin
ms_count
end))


let __proj__Mkms__item__ms_elems : ms  ->  key_t FStar_Set.set = (fun ( projectee  :  ms ) -> (match (projectee) with
| {ms_count = ms_count; ms_elems = ms_elems} -> begin
ms_elems
end))


let ms_empty : ms = {ms_count = (fun ( uu___  :  key_t ) -> (Prims.parse_int "0")); ms_elems = (FStar_Set.empty ())}


let ms_singleton : key_t  ->  ms = (fun ( x  :  key_t ) -> {ms_count = (fun ( x'  :  key_t ) -> (match ((Prims.op_Equality x' x)) with
| true -> begin
(Prims.parse_int "1")
end
| uu___ -> begin
(Prims.parse_int "0")
end)); ms_elems = (FStar_Set.singleton x)})


let ms_append : ms  ->  ms  ->  ms = (fun ( ms1  :  ms ) ( ms2  :  ms ) -> {ms_count = (fun ( x  :  key_t ) -> ((ms1.ms_count x) + (ms2.ms_count x))); ms_elems = (FStar_Set.union ms1.ms_elems ms2.ms_elems)})


let ms_cons : key_t  ->  ms  ->  ms = (fun ( x  :  key_t ) ( ms1  :  ms ) -> (ms_append (ms_singleton x) ms1))


type permutation =
unit


let rec keys_of_tree : tree  ->  ms = (fun ( t  :  tree ) -> (match (t) with
| Leaf -> begin
ms_empty
end
| Internal (left, k, right) -> begin
(ms_append (keys_of_tree left) (ms_cons k (keys_of_tree right)))
end))


let rec keys : forest  ->  ms = (fun ( q  :  forest ) -> (match (q) with
| [] -> begin
ms_empty
end
| (hd)::tl -> begin
(ms_append (keys_of_tree hd) (keys tl))
end))


type repr_t =
unit


type repr_l =
unit



type max =
unit




