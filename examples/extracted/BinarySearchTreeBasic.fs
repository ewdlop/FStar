#light "off"
module BinarySearchTreeBasic
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
| Node (n, _1, _2) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Node__item__n : tree  ->  Prims.int = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (n, _1, _2) -> begin
n
end))


let __proj__Node__item___1 : tree  ->  tree = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (n, _1, _2) -> begin
_1
end))


let __proj__Node__item___2 : tree  ->  tree = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (n, _1, _2) -> begin
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


let lt : Prims.int  ->  Prims.int  ->  Prims.bool = (fun ( n1  :  Prims.int ) ( n2  :  Prims.int ) -> (n1 < n2))


let gt : Prims.int  ->  Prims.int  ->  Prims.bool = (fun ( n1  :  Prims.int ) ( n2  :  Prims.int ) -> (n1 > n2))


let rec is_bst : tree  ->  Prims.bool = (fun ( t  :  tree ) -> (match (t) with
| Leaf -> begin
true
end
| Node (n, t1, t2) -> begin
((((all (gt n) t1) && (all (lt n) t2)) && (is_bst t1)) && (is_bst t2))
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


let rec insert' : Prims.int  ->  tree  ->  tree = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
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
(

let y = (insert' x t1)
in Node (n, (insert' x t1), t2))
end
| uu___1 -> begin
Node (n, t1, (insert' x t2))
end)
end)
end))


let rec insert'' : Prims.int  ->  tree  ->  tree = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
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
Node (n, (insert'' x t1), t2)
end
| uu___1 -> begin
Node (n, t1, (insert'' x t2))
end)
end)
end))


let ge : Prims.int  ->  Prims.int  ->  Prims.bool = (fun ( n1  :  Prims.int ) ( n2  :  Prims.int ) -> (n1 >= n2))


let rec find_max : tree  ->  Prims.int = (fun ( uu___  :  tree ) -> (match (uu___) with
| Node (n, uu___1, t2) -> begin
(match ((uu___is_Leaf t2)) with
| true -> begin
n
end
| uu___2 -> begin
(find_max t2)
end)
end))


let rec find_max' : tree  ->  Prims.int = (fun ( uu___  :  tree ) -> (match (uu___) with
| Node (n, uu___1, t2) -> begin
(match ((uu___is_Leaf t2)) with
| true -> begin
n
end
| uu___2 -> begin
(find_max' t2)
end)
end))


let rec delete : Prims.int  ->  tree  ->  tree = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
Leaf
end
| Node (n, t1, t2) -> begin
(match ((Prims.op_Equality n x)) with
| true -> begin
(match (((t1), (t2))) with
| (Leaf, Leaf) -> begin
Leaf
end
| (uu___, Leaf) -> begin
t1
end
| (Leaf, uu___) -> begin
t2
end
| uu___ -> begin
(

let y = (find_max t1)
in Node (y, (delete y t1), t2))
end)
end
| uu___ -> begin
(match ((x < n)) with
| true -> begin
Node (n, (delete x t1), t2)
end
| uu___1 -> begin
Node (n, t1, (delete x t2))
end)
end)
end))


let rec delete' : Prims.int  ->  tree  ->  tree = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
Leaf
end
| Node (n, t1, t2) -> begin
(match ((Prims.op_Equality n x)) with
| true -> begin
(match (((t1), (t2))) with
| (Leaf, Leaf) -> begin
Leaf
end
| (uu___, Leaf) -> begin
t1
end
| (Leaf, uu___) -> begin
t2
end
| uu___ -> begin
(

let y = (find_max' t1)
in Node (y, (delete' y t1), t2))
end)
end
| uu___ -> begin
(match ((x < n)) with
| true -> begin
Node (n, (delete' x t1), t2)
end
| uu___1 -> begin
Node (n, t1, (delete' x t2))
end)
end)
end))




