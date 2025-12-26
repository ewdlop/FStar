#light "off"
module LeftistHeap
type 'a ordered =
{leq : 'a  ->  'a  ->  Prims.bool; properties : unit}


let __proj__Mkordered__item__leq = (fun ( projectee  :  'a ordered ) -> (match (projectee) with
| {leq = leq; properties = properties} -> begin
leq
end))


let leq = (fun ( projectee  :  'a ordered ) -> (match (projectee) with
| {leq = leq1; properties = properties} -> begin
leq1
end))


let gt = (fun ( uu___  :  't ordered ) ( a  :  't ) ( b  :  't ) -> ((leq uu___ b a) && (Prims.op_disEquality a b)))


let ints_leq : Prims.int ordered = {leq = Prims.op_LessThanOrEqual; properties = ()}


let nats_leq : Prims.nat ordered = {leq = Prims.op_LessThanOrEqual; properties = ()}

type 'a heap =
| Leaf
| Node of 'a * 'a heap * 'a heap * Prims.nat


let uu___is_Leaf = (fun ( projectee  :  'a heap ) -> (match (projectee) with
| Leaf -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Node = (fun ( projectee  :  'a heap ) -> (match (projectee) with
| Node (key, left, right, rank) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Node__item__key = (fun ( projectee  :  'a heap ) -> (match (projectee) with
| Node (key, left, right, rank) -> begin
key
end))


let __proj__Node__item__left = (fun ( projectee  :  'a heap ) -> (match (projectee) with
| Node (key, left, right, rank) -> begin
left
end))


let __proj__Node__item__right = (fun ( projectee  :  'a heap ) -> (match (projectee) with
| Node (key, left, right, rank) -> begin
right
end))


let __proj__Node__item__rank = (fun ( projectee  :  'a heap ) -> (match (projectee) with
| Node (key, left, right, rank) -> begin
rank
end))


type heap_property =
obj


let measure = (fun ( uu___  :  'a ordered ) ( t1  :  'a heap ) ( t2  :  'a heap ) -> (match (((t1), (t2))) with
| (Node (uu___1, uu___2, uu___3, uu___4), Leaf) -> begin
(Prims.parse_int "1")
end
| (Node (k1, uu___1, uu___2, uu___3), Node (k2, uu___4, uu___5, uu___6)) -> begin
(match ((gt uu___ k1 k2)) with
| true -> begin
(Prims.parse_int "1")
end
| uu___7 -> begin
(Prims.parse_int "0")
end)
end
| uu___1 -> begin
(Prims.parse_int "0")
end))


let rank = (fun ( t  :  'uuuuu heap ) -> (match (t) with
| Leaf -> begin
(Prims.parse_int "0")
end
| Node (uu___, uu___1, uu___2, r) -> begin
r
end))


let rec merge_heaps_aux = (fun ( uu___  :  'a ordered ) ( t1  :  'a heap ) ( t2  :  'a heap ) -> (match (((t1), (t2))) with
| (Leaf, uu___1) -> begin
t2
end
| (uu___1, Leaf) -> begin
t1
end
| (Node (k1, l, r, uu___1), Node (k2, uu___2, uu___3, uu___4)) -> begin
(match ((gt uu___ k1 k2)) with
| true -> begin
(merge_heaps_aux uu___ t2 t1)
end
| uu___5 -> begin
(

let merged = (merge_heaps_aux uu___ r t2)
in (

let rank_left = (rank l)
in (

let rank_right = (rank merged)
in (match ((rank_left >= rank_right)) with
| true -> begin
Node (k1, l, merged, (rank_right + (Prims.parse_int "1")))
end
| uu___6 -> begin
Node (k1, merged, l, (rank_left + (Prims.parse_int "1")))
end))))
end)
end))



let empty = (fun ( uu___  :  'a ordered ) -> Leaf)


let isEmpty = (fun ( uu___  :  'a ordered ) ( t  :  ('a, obj) leftist ) -> (uu___is_Leaf t))


let singleton = (fun ( uu___  :  'a ordered ) ( k  :  'a ) -> Node (k, Leaf, Leaf, (Prims.parse_int "1")))


let merge_heaps = (fun ( uu___  :  'a ordered ) ( t1  :  ('a, obj) leftist ) ( t2  :  ('a, obj) leftist ) -> (merge_heaps_aux uu___ t1 t2))


let insert = (fun ( uu___  :  'a ordered ) ( x  :  'a ) ( t  :  ('a, obj) leftist ) -> (merge_heaps uu___ (singleton uu___ x) t))


let get_min = (fun ( uu___  :  'a ordered ) ( t  :  ('a, obj) leftist ) -> (match (t) with
| Node (k, uu___1, uu___2, uu___3) -> begin
k
end))


let delete_min = (fun ( uu___  :  'a ordered ) ( t  :  ('a, obj) leftist ) -> (match (t) with
| Node (uu___1, l, r, uu___2) -> begin
(merge_heaps uu___ l r)
end))




