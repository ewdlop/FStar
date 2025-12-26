#light "off"
module BinaryTrees
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
| Node (root, left, right) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Node__item__root : tree  ->  Prims.int = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (root, left, right) -> begin
root
end))


let __proj__Node__item__left : tree  ->  tree = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (root, left, right) -> begin
left
end))


let __proj__Node__item__right : tree  ->  tree = (fun ( projectee  :  tree ) -> (match (projectee) with
| Node (root, left, right) -> begin
right
end))


let rec size : tree  ->  Prims.nat = (fun ( t  :  tree ) -> (match (t) with
| Leaf -> begin
(Prims.parse_int "0")
end
| Node (n, t1, t2) -> begin
(((Prims.parse_int "1") + (size t1)) + (size t2))
end))


let rec map : (Prims.int  ->  Prims.int)  ->  tree  ->  tree = (fun ( f  :  Prims.int  ->  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
Leaf
end
| Node (n, t1, t2) -> begin
Node ((f n), (map f t1), (map f t2))
end))


let rec find : (Prims.int  ->  Prims.bool)  ->  tree  ->  Prims.int FStar_Pervasives_Native.option = (fun ( p  :  Prims.int  ->  Prims.bool ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
FStar_Pervasives_Native.None
end
| Node (n, t1, t2) -> begin
(match ((p n)) with
| true -> begin
FStar_Pervasives_Native.Some (n)
end
| uu___ -> begin
(match ((FStar_Pervasives_Native.uu___is_Some (find p t1))) with
| true -> begin
(find p t1)
end
| uu___1 -> begin
(find p t2)
end)
end)
end))


let map_option = (fun ( f  :  'uuuuu  ->  'uuuuu1 ) ( o  :  'uuuuu FStar_Pervasives_Native.option ) -> (match (o) with
| FStar_Pervasives_Native.Some (n) -> begin
FStar_Pervasives_Native.Some ((f n))
end
| FStar_Pervasives_Native.None -> begin
FStar_Pervasives_Native.None
end))


let compose = (fun ( f1  :  'uuuuu  ->  'uuuuu1 ) ( f2  :  'uuuuu2  ->  'uuuuu ) ( x  :  'uuuuu2 ) -> (f1 (f2 x)))


let rec in_tree : Prims.int  ->  tree  ->  Prims.bool = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
false
end
| Node (n, t1, t2) -> begin
(((Prims.op_Equality x n) || (in_tree x t1)) || (in_tree x t2))
end))


let rec fold = (fun ( f  :  Prims.int  ->  'a  ->  'a  ->  'a ) ( a1  :  'a ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
a1
end
| Node (n, t1, t2) -> begin
(f n (fold f a1 t1) (fold f a1 t2))
end))


let find_fold : (Prims.int  ->  Prims.bool)  ->  tree  ->  Prims.int FStar_Pervasives_Native.option = (fun ( f  :  Prims.int  ->  Prims.bool ) -> (fold (fun ( n  :  Prims.int ) ( o1  :  Prims.int FStar_Pervasives_Native.option ) ( o2  :  Prims.int FStar_Pervasives_Native.option ) -> (match ((f n)) with
| true -> begin
FStar_Pervasives_Native.Some (n)
end
| uu___ -> begin
(match ((FStar_Pervasives_Native.uu___is_Some o1)) with
| true -> begin
o1
end
| uu___1 -> begin
o2
end)
end)) FStar_Pervasives_Native.None))


let rec revert : tree  ->  tree = (fun ( t  :  tree ) -> (match (t) with
| Leaf -> begin
Leaf
end
| Node (n, t1, t2) -> begin
Node (n, (revert t2), (revert t1))
end))


let rec remove_root : tree  ->  tree = (fun ( t  :  tree ) -> (match (t) with
| Node (n, t1, t2) -> begin
(match ((uu___is_Leaf t1)) with
| true -> begin
t2
end
| uu___ -> begin
Node ((__proj__Node__item__root t1), (remove_root t1), t2)
end)
end))


let rec add_root : Prims.int  ->  tree  ->  tree = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
Node (x, Leaf, Leaf)
end
| Node (n, t1, t2) -> begin
Node (x, (add_root n t1), t2)
end))


let rec count : Prims.int  ->  tree  ->  Prims.nat = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Leaf -> begin
(Prims.parse_int "0")
end
| Node (n, t1, t2) -> begin
(((match ((Prims.op_Equality n x)) with
| true -> begin
(Prims.parse_int "1")
end
| uu___ -> begin
(Prims.parse_int "0")
end) + (count x t1)) + (count x t2))
end))


let rec remove : Prims.int  ->  tree  ->  tree = (fun ( x  :  Prims.int ) ( t  :  tree ) -> (match (t) with
| Node (n, t1, t2) -> begin
(match ((Prims.op_Equality x n)) with
| true -> begin
(remove_root t)
end
| uu___ -> begin
(match (((count x t1) > (Prims.parse_int "0"))) with
| true -> begin
Node (n, (remove x t1), t2)
end
| uu___1 -> begin
Node (n, t1, (remove x t2))
end)
end)
end))




