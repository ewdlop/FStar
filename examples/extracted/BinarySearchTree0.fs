#light "off"
module BinarySearchTree0
type tree =
| Leaf
| Node of Prims.int * tree * tree


let uu___is_Leaf : tree  ->  Prims.bool = (fun ( projectee  :  tree ) -> (match (projectee) with
| Leaf -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Node : tree  ->  Prims.bool = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (_0, _1, _2) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Node__item___0 : tree  ->  Prims.int = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (_0, _1, _2) -> begin
_0
end))


let __proj__Node__item___1 : tree  ->  tree = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (_0, _1, _2) -> begin
_1
end))


let __proj__Node__item___2 : tree  ->  tree = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (_0, _1, _2) -> begin
_2
end))


let rec search : Prims.int  ->  tree  ->  Prims.bool = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
false
end
| Node (n, t1, t2) -> begin
(match ((Prims.op_Equality x n)) with
| true -> begin
true
end
| uu___ -> begin
(match ((x < n)) with
| true -> begin
(search x t1)
end
| uu___1 -> begin
(search x t2)
end)
end)
end))


let rec insert : Prims.int  ->  tree  ->  tree = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
Node (x, Leaf, Leaf)
end
| Node (n, t1, t2) -> begin
(match ((Prims.op_Equality x n)) with
| true -> begin
t
end
| uu___ -> begin
(match ((x < n)) with
| true -> begin
Node (n, (insert x t1), t2)
end
| uu___1 -> begin
Node (n, t1, (insert x t2))
end)
end)
end))




