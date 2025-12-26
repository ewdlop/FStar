#light "off"
module BinarySearchTree
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


let rec in_tree : Prims.int  ->  tree  ->  Prims.bool = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
false
end
| Node (n, t1, t2) -> begin
(((Prims.op_Equality x n) || (in_tree x t1)) || (in_tree x t2))
end))


let rec all : (Prims.int  ->  Prims.bool)  ->  tree  ->  Prims.bool = (fun ( p  :  Prims.int  ->  Prims.bool ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
true
end
| Node (n, t1, t2) -> begin
(((p n) && (all p t1)) && (all p t2))
end))


let rec is_bst : tree  ->  Prims.bool = (fun ( t  :  tree ) -> (match (t) with
| Leaf -> begin
true
end
| Node (n, t1, t2) -> begin
((((all (fun ( n'  :  Prims.int ) -> (n > n')) t1) && (all (fun ( n'  :  Prims.int ) -> (n < n')) t2)) && (is_bst t1)) && (is_bst t2))
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




