#light "off"
module RBTreeIntrinsic
type color =
| Red
| Black


let uu___is_Red : color  ->  Prims.bool = (fun ( projectee  :  color ) -> (match (projectee) with
| Red -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Black : color  ->  Prims.bool = (fun ( projectee  :  color ) -> (match (projectee) with
| Black -> begin
true
end
| uu___ -> begin
false
end))


let chain : Prims.int FStar_Pervasives_Native.option  ->  Prims.int  ->  Prims.int FStar_Pervasives_Native.option  ->  Prims.bool = (fun ( x  :  Prims.int FStar_Pervasives_Native.option ) ( y  :  Prims.int ) ( z  :  Prims.int FStar_Pervasives_Native.option ) -> (match (((x), (z))) with
| (FStar_Pervasives_Native.Some (x1), FStar_Pervasives_Native.Some (z1)) -> begin
((x1 <= y) && (y <= z1))
end
| (FStar_Pervasives_Native.Some (x1), FStar_Pervasives_Native.None) -> begin
(x1 <= y)
end
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.Some (z1)) -> begin
(y <= z1)
end
| uu___ -> begin
true
end))

type ('dummyV0, 'dummyV1) rbnode =
| Leaf
| R of Prims.nat * (obj, obj) rbnode * Prims.int * (obj, obj) rbnode
| B of Prims.nat * color * color * (obj, obj) rbnode * Prims.int * (obj, obj) rbnode


let uu___is_Leaf : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| Leaf -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_R : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| R (h1, left, value, right) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__R__item__h : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.nat = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| R (h1, left, value, right) -> begin
h1
end))


let __proj__R__item__left : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| R (h1, left, value, right) -> begin
left
end))


let __proj__R__item__value : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.int = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| R (h1, left, value, right) -> begin
value
end))


let __proj__R__item__right : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| R (h1, left, value, right) -> begin
right
end))


let uu___is_B : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| B (h1, cl, cr, left, value, right) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__B__item__h : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.nat = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| B (h1, cl, cr, left, value, right) -> begin
h1
end))


let __proj__B__item__cl : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  color = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| B (h1, cl, cr, left, value, right) -> begin
cl
end))


let __proj__B__item__cr : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  color = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| B (h1, cl, cr, left, value, right) -> begin
cr
end))


let __proj__B__item__left : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| B (h1, cl, cr, left, value, right) -> begin
left
end))


let __proj__B__item__value : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.int = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| B (h1, cl, cr, left, value, right) -> begin
value
end))


let __proj__B__item__right : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( c  :  color ) ( projectee  :  (obj, obj) rbnode ) -> (match (projectee) with
| B (h1, cl, cr, left, value, right) -> begin
right
end))


let rec reduceNode : Prims.nat  ->  color  ->  (Prims.int  ->  Prims.int  ->  Prims.int)  ->  (obj, obj) rbnode  ->  Prims.int FStar_Pervasives_Native.option = (fun ( h  :  Prims.nat ) ( c  :  color ) ( f  :  Prims.int  ->  Prims.int  ->  Prims.int ) ( uu___  :  (obj, obj) rbnode ) -> (match (uu___) with
| Leaf -> begin
FStar_Pervasives_Native.None
end
| B (uu___1, uu___2, uu___3, left, value, right) -> begin
(match ((((reduceNode uu___1 uu___2 f left)), ((reduceNode uu___1 uu___3 f right)))) with
| (FStar_Pervasives_Native.Some (l), FStar_Pervasives_Native.Some (r)) -> begin
FStar_Pervasives_Native.Some ((f value (f l r)))
end
| (FStar_Pervasives_Native.Some (x), FStar_Pervasives_Native.None) -> begin
FStar_Pervasives_Native.Some ((f x value))
end
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.Some (x)) -> begin
FStar_Pervasives_Native.Some ((f x value))
end
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.None) -> begin
FStar_Pervasives_Native.Some (value)
end)
end
| R (uu___1, left, value, right) -> begin
(match ((((reduceNode uu___1 Black f left)), ((reduceNode uu___1 Black f right)))) with
| (FStar_Pervasives_Native.Some (l), FStar_Pervasives_Native.Some (r)) -> begin
FStar_Pervasives_Native.Some ((f value (f l r)))
end
| (FStar_Pervasives_Native.Some (x), FStar_Pervasives_Native.None) -> begin
FStar_Pervasives_Native.Some ((f x value))
end
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.Some (x)) -> begin
FStar_Pervasives_Native.Some ((f x value))
end
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.None) -> begin
FStar_Pervasives_Native.Some (value)
end)
end))


let min : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.int FStar_Pervasives_Native.option = (fun ( h  :  Prims.nat ) ( c  :  color ) ( t  :  (obj, obj) rbnode ) -> (reduceNode h c (fun ( x  :  Prims.int ) ( y  :  Prims.int ) -> (match ((x < y)) with
| true -> begin
x
end
| uu___ -> begin
y
end)) t))


let max : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.int FStar_Pervasives_Native.option = (fun ( h  :  Prims.nat ) ( c  :  color ) ( t  :  (obj, obj) rbnode ) -> (reduceNode h c (fun ( x  :  Prims.int ) ( y  :  Prims.int ) -> (match ((x > y)) with
| true -> begin
x
end
| uu___ -> begin
y
end)) t))


let rec sorted : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( c  :  color ) ( uu___  :  (obj, obj) rbnode ) -> (match (uu___) with
| Leaf -> begin
true
end
| B (uu___1, uu___2, uu___3, left, value, right) -> begin
(((sorted uu___1 uu___2 left) && (sorted uu___1 uu___3 right)) && (chain (max uu___1 uu___2 left) value (min uu___1 uu___3 right)))
end
| R (uu___1, left, value, right) -> begin
(((sorted uu___1 Black left) && (sorted uu___1 Black right)) && (chain (max uu___1 Black left) value (min uu___1 Black right)))
end))

type rbtree =
| RBTree of Prims.nat * (obj, obj) rbnode


let uu___is_RBTree : rbtree  ->  Prims.bool = (fun ( projectee  :  rbtree ) -> true)


let __proj__RBTree__item__h : rbtree  ->  Prims.nat = (fun ( projectee  :  rbtree ) -> (match (projectee) with
| RBTree (h, root) -> begin
h
end))


let __proj__RBTree__item__root : rbtree  ->  (obj, obj) rbnode = (fun ( projectee  :  rbtree ) -> (match (projectee) with
| RBTree (h, root) -> begin
root
end))

type 'dummyV0 hiddenTree =
| HR of Prims.nat * (obj, obj) rbnode
| HB of Prims.nat * (obj, obj) rbnode


let uu___is_HR : Prims.nat  ->  obj hiddenTree  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( projectee  :  obj hiddenTree ) -> (match (projectee) with
| HR (h1, node) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__HR__item__h : Prims.nat  ->  obj hiddenTree  ->  Prims.nat = (fun ( h  :  Prims.nat ) ( projectee  :  obj hiddenTree ) -> (match (projectee) with
| HR (h1, node) -> begin
h1
end))


let __proj__HR__item__node : Prims.nat  ->  obj hiddenTree  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( projectee  :  obj hiddenTree ) -> (match (projectee) with
| HR (h1, node) -> begin
node
end))


let uu___is_HB : Prims.nat  ->  obj hiddenTree  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( projectee  :  obj hiddenTree ) -> (match (projectee) with
| HB (h1, node) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__HB__item__h : Prims.nat  ->  obj hiddenTree  ->  Prims.nat = (fun ( h  :  Prims.nat ) ( projectee  :  obj hiddenTree ) -> (match (projectee) with
| HB (h1, node) -> begin
h1
end))


let __proj__HB__item__node : Prims.nat  ->  obj hiddenTree  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( projectee  :  obj hiddenTree ) -> (match (projectee) with
| HB (h1, node) -> begin
node
end))

type 'dummyV0 almostNode =
| LR of Prims.nat * color * (obj, obj) rbnode * Prims.int * (obj, obj) rbnode
| RR of Prims.nat * color * (obj, obj) rbnode * Prims.int * (obj, obj) rbnode
| V of Prims.nat * color * (obj, obj) rbnode


let uu___is_LR : Prims.nat  ->  obj almostNode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| LR (h1, cR, left, value, right) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__LR__item__h : Prims.nat  ->  obj almostNode  ->  Prims.nat = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| LR (h1, cR, left, value, right) -> begin
h1
end))


let __proj__LR__item__cR : Prims.nat  ->  obj almostNode  ->  color = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| LR (h1, cR, left, value, right) -> begin
cR
end))


let __proj__LR__item__left : Prims.nat  ->  obj almostNode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| LR (h1, cR, left, value, right) -> begin
left
end))


let __proj__LR__item__value : Prims.nat  ->  obj almostNode  ->  Prims.int = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| LR (h1, cR, left, value, right) -> begin
value
end))


let __proj__LR__item__right : Prims.nat  ->  obj almostNode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| LR (h1, cR, left, value, right) -> begin
right
end))


let uu___is_RR : Prims.nat  ->  obj almostNode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| RR (h1, cL, left, value, right) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__RR__item__h : Prims.nat  ->  obj almostNode  ->  Prims.nat = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| RR (h1, cL, left, value, right) -> begin
h1
end))


let __proj__RR__item__cL : Prims.nat  ->  obj almostNode  ->  color = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| RR (h1, cL, left, value, right) -> begin
cL
end))


let __proj__RR__item__left : Prims.nat  ->  obj almostNode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| RR (h1, cL, left, value, right) -> begin
left
end))


let __proj__RR__item__value : Prims.nat  ->  obj almostNode  ->  Prims.int = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| RR (h1, cL, left, value, right) -> begin
value
end))


let __proj__RR__item__right : Prims.nat  ->  obj almostNode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| RR (h1, cL, left, value, right) -> begin
right
end))


let uu___is_V : Prims.nat  ->  obj almostNode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| V (h1, c, node) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__V__item__h : Prims.nat  ->  obj almostNode  ->  Prims.nat = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| V (h1, c, node) -> begin
h1
end))


let __proj__V__item__c : Prims.nat  ->  obj almostNode  ->  color = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| V (h1, c, node) -> begin
c
end))


let __proj__V__item__node : Prims.nat  ->  obj almostNode  ->  (obj, obj) rbnode = (fun ( h  :  Prims.nat ) ( projectee  :  obj almostNode ) -> (match (projectee) with
| V (h1, c, node) -> begin
node
end))


let balanceLB : Prims.nat  ->  color  ->  obj almostNode  ->  Prims.int  ->  (obj, obj) rbnode  ->  obj hiddenTree = (fun ( h  :  Prims.nat ) ( c  :  color ) ( left  :  obj almostNode ) ( z  :  Prims.int ) ( d  :  (obj, obj) rbnode ) -> (match (left) with
| LR (uu___, uu___1, R (uu___2, a, x, b), y, c1) -> begin
HR ((uu___2 + (Prims.parse_int "1")), R ((uu___2 + (Prims.parse_int "1")), B (uu___2, Black, Black, a, x, b), y, B (uu___, uu___1, c, c1, z, d)))
end
| RR (uu___, uu___1, a, x, R (uu___2, b, y, c1)) -> begin
HR ((uu___ + (Prims.parse_int "1")), R ((uu___ + (Prims.parse_int "1")), B (uu___, uu___1, Black, a, x, b), y, B (uu___2, Black, c, c1, z, d)))
end
| V (uu___, uu___1, axb) -> begin
HB (uu___, B (uu___, uu___1, c, axb, z, d))
end))


let balanceRB : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.int  ->  obj almostNode  ->  obj hiddenTree = (fun ( h  :  Prims.nat ) ( c  :  color ) ( a  :  (obj, obj) rbnode ) ( x  :  Prims.int ) ( right  :  obj almostNode ) -> (match (right) with
| LR (uu___, uu___1, R (uu___2, b, y, c1), z, d) -> begin
HR ((h + (Prims.parse_int "1")), R ((h + (Prims.parse_int "1")), B (h, c, Black, a, x, b), y, B (uu___2, Black, uu___1, c1, z, d)))
end
| RR (uu___, uu___1, b, y, R (uu___2, c1, z, d)) -> begin
HR ((h + (Prims.parse_int "1")), R ((h + (Prims.parse_int "1")), B (h, c, uu___1, a, x, b), y, B (uu___2, Black, Black, c1, z, d)))
end
| V (uu___, uu___1, cyd) -> begin
HB (h, B (h, c, uu___1, a, x, cyd))
end))


let balanceLR : Prims.nat  ->  color  ->  obj hiddenTree  ->  Prims.int  ->  (obj, obj) rbnode  ->  obj almostNode = (fun ( h  :  Prims.nat ) ( c  :  color ) ( left  :  obj hiddenTree ) ( x  :  Prims.int ) ( right  :  (obj, obj) rbnode ) -> (match (left) with
| HR (uu___, a) -> begin
LR (uu___, c, a, x, right)
end
| HB (uu___, a) -> begin
(match (right) with
| R (uu___1, b, y, c1) -> begin
RR ((uu___ + (Prims.parse_int "1")), Black, a, x, R (uu___1, b, y, c1))
end
| B (uu___1, uu___2, uu___3, b, y, c1) -> begin
V ((uu___ + (Prims.parse_int "1")), Red, R ((uu___ + (Prims.parse_int "1")), a, x, B (uu___1, uu___2, uu___3, b, y, c1)))
end
| Leaf -> begin
V ((uu___ + (Prims.parse_int "1")), Red, R ((uu___ + (Prims.parse_int "1")), a, x, Leaf))
end)
end))


let balanceRR : Prims.nat  ->  color  ->  (obj, obj) rbnode  ->  Prims.int  ->  obj hiddenTree  ->  obj almostNode = (fun ( h  :  Prims.nat ) ( c  :  color ) ( left  :  (obj, obj) rbnode ) ( y  :  Prims.int ) ( right  :  obj hiddenTree ) -> (match (right) with
| HR (uu___, c1) -> begin
RR (h, c, left, y, c1)
end
| HB (uu___, c1) -> begin
(match (left) with
| R (uu___1, a, x, b) -> begin
LR (uu___1, Black, R (uu___1, a, x, b), y, c1)
end
| B (uu___1, uu___2, uu___3, a, x, b) -> begin
V ((uu___1 + (Prims.parse_int "1")), Red, R ((uu___1 + (Prims.parse_int "1")), B (uu___1, uu___2, uu___3, a, x, b), y, c1))
end
| Leaf -> begin
V ((Prims.parse_int "1"), Red, R ((Prims.parse_int "1"), Leaf, y, c1))
end)
end))


let rec ins : Prims.nat  ->  color  ->  Prims.int  ->  (obj, obj) rbnode  ->  obj almostNode = (fun ( h  :  Prims.nat ) ( c  :  color ) ( x  :  Prims.int ) ( uu___  :  (obj, obj) rbnode ) -> (match (uu___) with
| Leaf -> begin
V ((Prims.parse_int "1"), Red, R ((Prims.parse_int "1"), Leaf, x, Leaf))
end
| B (uu___1, uu___2, uu___3, a, y, b) -> begin
(match ((x < y)) with
| true -> begin
(match ((balanceLB uu___1 uu___3 (ins uu___1 uu___2 x a) y b)) with
| HR (uu___4, r) -> begin
V (uu___4, Red, r)
end
| HB (uu___4, b1) -> begin
V ((uu___4 + (Prims.parse_int "1")), Black, b1)
end)
end
| uu___4 -> begin
(match ((Prims.op_Equality x y)) with
| true -> begin
V ((uu___1 + (Prims.parse_int "1")), Black, B (uu___1, uu___2, uu___3, a, y, b))
end
| uu___5 -> begin
(match ((balanceRB uu___1 uu___2 a y (ins uu___1 uu___3 x b))) with
| HR (uu___6, r) -> begin
V (uu___6, Red, r)
end
| HB (uu___6, b1) -> begin
V ((uu___6 + (Prims.parse_int "1")), Black, b1)
end)
end)
end)
end
| R (uu___1, a, y, b) -> begin
(match ((x < y)) with
| true -> begin
(balanceLR uu___1 Black (insB uu___1 x a) y b)
end
| uu___2 -> begin
(match ((Prims.op_Equality x y)) with
| true -> begin
V (uu___1, Red, R (uu___1, a, y, b))
end
| uu___3 -> begin
(balanceRR uu___1 Black a y (insB uu___1 x b))
end)
end)
end))
and insB : Prims.nat  ->  Prims.int  ->  (obj, obj) rbnode  ->  obj hiddenTree = (fun ( h  :  Prims.nat ) ( x  :  Prims.int ) ( uu___  :  (obj, obj) rbnode ) -> (match (uu___) with
| Leaf -> begin
HR ((Prims.parse_int "1"), R ((Prims.parse_int "1"), Leaf, x, Leaf))
end
| B (uu___1, uu___2, uu___3, a, y, b) -> begin
(match ((x < y)) with
| true -> begin
(balanceLB uu___1 uu___3 (ins uu___1 uu___2 x a) y b)
end
| uu___4 -> begin
(match ((Prims.op_Equality x y)) with
| true -> begin
HB (uu___1, B (uu___1, uu___2, uu___3, a, y, b))
end
| uu___5 -> begin
(balanceRB uu___1 uu___2 a y (ins uu___1 uu___3 x b))
end)
end)
end))


let rec mem : Prims.nat  ->  color  ->  Prims.int  ->  (obj, obj) rbnode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( c  :  color ) ( x  :  Prims.int ) ( uu___  :  (obj, obj) rbnode ) -> (match (uu___) with
| Leaf -> begin
false
end
| B (uu___1, uu___2, uu___3, l, y, r) -> begin
(((Prims.op_Equality x y) || (mem uu___1 uu___2 x l)) || (mem uu___1 uu___3 x r))
end
| R (uu___1, l, y, r) -> begin
(((Prims.op_Equality x y) || (mem uu___1 Black x l)) || (mem uu___1 Black x r))
end))


let hiddenTree_mem : Prims.nat  ->  Prims.int  ->  obj hiddenTree  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( x  :  Prims.int ) ( uu___  :  obj hiddenTree ) -> (match (uu___) with
| HB (uu___1, root) -> begin
(mem (uu___1 + (Prims.parse_int "1")) Black x root)
end
| HR (uu___1, root) -> begin
(mem uu___1 Red x root)
end))


let almostNode_mem : Prims.nat  ->  Prims.int  ->  obj almostNode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( x  :  Prims.int ) ( uu___  :  obj almostNode ) -> (match (uu___) with
| LR (uu___1, uu___2, a, y, b) -> begin
(mem (uu___1 + (Prims.parse_int "1")) Black x (B (uu___1, Red, uu___2, a, y, b)))
end
| RR (uu___1, uu___2, a, y, b) -> begin
(mem (uu___1 + (Prims.parse_int "1")) Black x (B (uu___1, uu___2, Red, a, y, b)))
end
| V (uu___1, uu___2, root) -> begin
(mem uu___1 uu___2 x root)
end))


let almostNode_sorted : Prims.nat  ->  obj almostNode  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( uu___  :  obj almostNode ) -> (match (uu___) with
| LR (uu___1, uu___2, a, x, b) -> begin
(sorted (uu___1 + (Prims.parse_int "1")) Black (B (uu___1, Red, uu___2, a, x, b)))
end
| RR (uu___1, uu___2, a, x, b) -> begin
(sorted (uu___1 + (Prims.parse_int "1")) Black (B (uu___1, uu___2, Red, a, x, b)))
end
| V (uu___1, uu___2, root) -> begin
(sorted uu___1 uu___2 root)
end))


let hiddenTree_sorted : Prims.nat  ->  obj hiddenTree  ->  Prims.bool = (fun ( h  :  Prims.nat ) ( uu___  :  obj hiddenTree ) -> (match (uu___) with
| HB (uu___1, root) -> begin
(sorted (uu___1 + (Prims.parse_int "1")) Black root)
end
| HR (uu___1, root) -> begin
(sorted uu___1 Red root)
end))


let hiddenTree_max : Prims.nat  ->  obj hiddenTree  ->  Prims.int FStar_Pervasives_Native.option = (fun ( h  :  Prims.nat ) ( uu___  :  obj hiddenTree ) -> (match (uu___) with
| HB (uu___1, root) -> begin
(max (uu___1 + (Prims.parse_int "1")) Black root)
end
| HR (uu___1, root) -> begin
(max uu___1 Red root)
end))


let hiddenTree_min : Prims.nat  ->  obj hiddenTree  ->  Prims.int FStar_Pervasives_Native.option = (fun ( h  :  Prims.nat ) ( uu___  :  obj hiddenTree ) -> (match (uu___) with
| HB (uu___1, root) -> begin
(min (uu___1 + (Prims.parse_int "1")) Black root)
end
| HR (uu___1, root) -> begin
(min uu___1 Red root)
end))


let almostNode_max : Prims.nat  ->  obj almostNode  ->  Prims.int FStar_Pervasives_Native.option = (fun ( h  :  Prims.nat ) ( uu___  :  obj almostNode ) -> (match (uu___) with
| LR (uu___1, uu___2, a, x, b) -> begin
(max (uu___1 + (Prims.parse_int "1")) Black (B (uu___1, Red, uu___2, a, x, b)))
end
| RR (uu___1, uu___2, a, x, b) -> begin
(max (uu___1 + (Prims.parse_int "1")) Black (B (uu___1, uu___2, Red, a, x, b)))
end
| V (uu___1, uu___2, R (uu___3, a, x, b)) -> begin
(max (uu___3 + (Prims.parse_int "1")) Black (B (uu___3, Black, Black, a, x, b)))
end
| V (uu___1, uu___2, B (uu___3, uu___4, uu___5, a, x, b)) -> begin
(max (uu___3 + (Prims.parse_int "1")) Black (B (uu___3, uu___4, uu___5, a, x, b)))
end
| V (uu___1, uu___2, Leaf) -> begin
FStar_Pervasives_Native.None
end))


let almostNode_min : Prims.nat  ->  obj almostNode  ->  Prims.int FStar_Pervasives_Native.option = (fun ( h  :  Prims.nat ) ( uu___  :  obj almostNode ) -> (match (uu___) with
| LR (uu___1, uu___2, a, x, b) -> begin
(min (uu___1 + (Prims.parse_int "1")) Black (B (uu___1, Red, uu___2, a, x, b)))
end
| RR (uu___1, uu___2, a, x, b) -> begin
(min (uu___1 + (Prims.parse_int "1")) Black (B (uu___1, uu___2, Red, a, x, b)))
end
| V (uu___1, uu___2, R (uu___3, a, x, b)) -> begin
(min (uu___3 + (Prims.parse_int "1")) Black (B (uu___3, Black, Black, a, x, b)))
end
| V (uu___1, uu___2, B (uu___3, uu___4, uu___5, a, x, b)) -> begin
(min (uu___3 + (Prims.parse_int "1")) Black (B (uu___3, uu___4, uu___5, a, x, b)))
end
| V (uu___1, uu___2, Leaf) -> begin
FStar_Pervasives_Native.None
end))


let atLeast : Prims.int  ->  Prims.int FStar_Pervasives_Native.option  ->  Prims.bool = (fun ( x  :  Prims.int ) ( uu___  :  Prims.int FStar_Pervasives_Native.option ) -> (match (uu___) with
| FStar_Pervasives_Native.Some (y) -> begin
(x <= y)
end
| FStar_Pervasives_Native.None -> begin
true
end))


let atMost : Prims.int  ->  Prims.int FStar_Pervasives_Native.option  ->  Prims.bool = (fun ( x  :  Prims.int ) ( uu___  :  Prims.int FStar_Pervasives_Native.option ) -> (match (uu___) with
| FStar_Pervasives_Native.Some (y) -> begin
(x >= y)
end
| FStar_Pervasives_Native.None -> begin
true
end))


let insert : Prims.int  ->  rbtree  ->  rbtree = (fun ( x  :  Prims.int ) ( tree  :  rbtree ) -> (match ((ins (__proj__RBTree__item__h tree) Black x (__proj__RBTree__item__root tree))) with
| LR (uu___, uu___1, a, x1, b) -> begin
RBTree ((uu___ + (Prims.parse_int "1")), B (uu___, Red, uu___1, a, x1, b))
end
| RR (uu___, uu___1, a, x1, b) -> begin
RBTree ((uu___ + (Prims.parse_int "1")), B (uu___, uu___1, Red, a, x1, b))
end
| V (uu___, uu___1, B (uu___2, uu___3, uu___4, a, x1, b)) -> begin
RBTree ((uu___2 + (Prims.parse_int "1")), B (uu___2, uu___3, uu___4, a, x1, b))
end
| V (uu___, uu___1, R (uu___2, a, x1, b)) -> begin
RBTree ((uu___2 + (Prims.parse_int "1")), B (uu___2, Black, Black, a, x1, b))
end))


let sanity_check1 : rbtree = (

let t = B ((Prims.parse_int "2"), Black, Black, B ((Prims.parse_int "1"), Black, Black, Leaf, (Prims.parse_int "2"), Leaf), (Prims.parse_int "5"), B ((Prims.parse_int "1"), Black, Black, Leaf, (Prims.parse_int "8"), Leaf))
in RBTree ((Prims.parse_int "3"), t))


let rec repeat : Prims.string  ->  Prims.nat  ->  Prims.string = (fun ( s  :  Prims.string ) ( n  :  Prims.nat ) -> (match (n) with
| uu___ when (uu___ = (Prims.parse_int "0")) -> begin
""
end
| n1 -> begin
(Prims.strcat s (repeat s (n1 - (Prims.parse_int "1"))))
end))


let node_to_string : Prims.string  ->  color  ->  Prims.string  ->  Prims.string  ->  Prims.string = (fun ( b  :  Prims.string ) ( c  :  color ) ( indent  :  Prims.string ) ( s  :  Prims.string ) -> (

let node = (fun ( uu___  :  color ) -> (match (uu___) with
| Red -> begin
"○"
end
| Black -> begin
"●"
end))
in (Prims.strcat indent (Prims.strcat b (Prims.strcat (node c) (Prims.strcat s "\n"))))))


let rec rbnode_to_string : Prims.nat  ->  color  ->  Prims.string  ->  Prims.nat  ->  (obj, obj) rbnode  ->  Prims.string = (fun ( h  :  Prims.nat ) ( c  :  color ) ( b  :  Prims.string ) ( h0  :  Prims.nat ) ( root  :  (obj, obj) rbnode ) -> (

let indent = (repeat "     " (h0 - h))
in (match (root) with
| Leaf -> begin
(node_to_string b Black indent "")
end
| R (uu___, left, v, right) -> begin
(Prims.strcat (rbnode_to_string uu___ Black "┌─" (h0 + (Prims.parse_int "1")) left) (Prims.strcat (node_to_string b c indent (Prims.strcat (Prims.string_of_int v) (Prims.strcat (match ((v < (Prims.parse_int "10"))) with
| true -> begin
" "
end
| uu___1 -> begin
""
end) "┤"))) (rbnode_to_string uu___ Black "└─" (h0 + (Prims.parse_int "1")) right)))
end
| B (uu___, uu___1, uu___2, left, v, right) -> begin
(Prims.strcat (rbnode_to_string uu___ uu___1 "┌─" h0 left) (Prims.strcat (node_to_string b c indent (Prims.strcat (Prims.string_of_int v) (Prims.strcat (match ((v < (Prims.parse_int "10"))) with
| true -> begin
" "
end
| uu___3 -> begin
""
end) "┤"))) (rbnode_to_string uu___ uu___2 "└─" h0 right)))
end)))


let rbtree_to_string : rbtree  ->  Prims.string = (fun ( t  :  rbtree ) -> (rbnode_to_string (__proj__RBTree__item__h t) Black "──" (__proj__RBTree__item__h t) (__proj__RBTree__item__root t)))


let rec loop : rbtree  ->  unit = (fun ( t  :  rbtree ) -> ((FStar_IO.print_string (rbtree_to_string t));
(FStar_IO.print_string "Insert> ");
(

let i = (FStar_IO.input_int ())
in (

let u = (insert i t)
in (loop u)));
))


let test : unit  ->  unit = (fun ( uu___  :  unit ) -> (loop (RBTree ((Prims.parse_int "1"), Leaf))))




