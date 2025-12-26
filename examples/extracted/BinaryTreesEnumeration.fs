#light "off"
module BinaryTreesEnumeration

type prod_with_sum =
(Prims.nat * Prims.nat)


let rec pairs_with_sum' : Prims.nat  ->  Prims.nat  ->  prod_with_sum Prims.list = (fun ( m  :  Prims.nat ) ( n  :  Prims.nat ) -> (((m), (n)))::(match ((Prims.op_Equality m (Prims.parse_int "0"))) with
| true -> begin
[]
end
| uu___ -> begin
(pairs_with_sum' (m - (Prims.parse_int "1")) (n + (Prims.parse_int "1")))
end))


let pairs_with_sum : Prims.nat  ->  prod_with_sum Prims.list = (fun ( n  :  Prims.nat ) -> (pairs_with_sum' n (Prims.parse_int "0")))


let product = (fun ( l1  :  'a Prims.list ) ( l2  :  'b Prims.list ) -> (FStar_List_Tot_Base.concatMap (fun ( x1  :  'a ) -> (FStar_List_Tot_Base.map (fun ( x2  :  'b ) -> ((x1), (x2))) l2)) l1))

type bin_tree =
| Leaf
| Branch of (bin_tree * bin_tree)


let uu___is_Leaf : bin_tree  ->  Prims.bool = (fun ( projectee  :  bin_tree ) -> (match (projectee) with
| Leaf -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Branch : bin_tree  ->  Prims.bool = (fun ( projectee  :  bin_tree ) -> (match (projectee) with
| Branch (_0) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Branch__item___0 : bin_tree  ->  (bin_tree * bin_tree) = (fun ( projectee  :  bin_tree ) -> (match (projectee) with
| Branch (_0) -> begin
_0
end))


let rec size : bin_tree  ->  Prims.nat = (fun ( bt  :  bin_tree ) -> (match (bt) with
| Leaf -> begin
(Prims.parse_int "0")
end
| Branch (l, r) -> begin
(((Prims.parse_int "1") + (size l)) + (size r))
end))


type bt_with_size =
bin_tree


let rec trees_of_size : Prims.nat  ->  bt_with_size Prims.list = (fun ( s  :  Prims.nat ) -> (match ((Prims.op_Equality s (Prims.parse_int "0"))) with
| true -> begin
(Leaf)::[]
end
| uu___ -> begin
(FStar_List_Tot_Base.concatMap (fun ( uu___1  :  prod_with_sum ) -> (match (uu___1) with
| (s1, s2) -> begin
(FStar_List_Tot_Base.map (fun ( uu___2  :  (bt_with_size * bt_with_size) ) -> (match (uu___2) with
| (t1, t2) -> begin
Branch (((t1), (t2)))
end)) (product (trees_of_size s1) (trees_of_size s2)))
end)) (pairs_with_sum (s - (Prims.parse_int "1"))))
end))




