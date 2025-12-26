#light "off"
module RBTree
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

type rbtree' =
| E
| T of color * rbtree' * Prims.nat * rbtree'


let uu___is_E : rbtree'  ->  Prims.bool = (fun ( projectee  :  rbtree' ) -> (match (projectee) with
| E -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_T : rbtree'  ->  Prims.bool = (fun ( projectee  :  rbtree' ) -> (match (projectee) with
| T (col, left, key, right) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__T__item__col : rbtree'  ->  color = (fun ( projectee  :  rbtree' ) -> (match (projectee) with
| T (col, left, key, right) -> begin
col
end))


let __proj__T__item__left : rbtree'  ->  rbtree' = (fun ( projectee  :  rbtree' ) -> (match (projectee) with
| T (col, left, key, right) -> begin
left
end))


let __proj__T__item__key : rbtree'  ->  Prims.nat = (fun ( projectee  :  rbtree' ) -> (match (projectee) with
| T (col, left, key, right) -> begin
key
end))


let __proj__T__item__right : rbtree'  ->  rbtree' = (fun ( projectee  :  rbtree' ) -> (match (projectee) with
| T (col, left, key, right) -> begin
right
end))


let color_of : rbtree'  ->  color = (fun ( t  :  rbtree' ) -> (match (t) with
| E -> begin
B
end
| T (c, uu___, uu___1, uu___2) -> begin
c
end))


let rec black_height : rbtree'  ->  Prims.nat FStar_Pervasives_Native.option = (fun ( t  :  rbtree' ) -> (match (t) with
| E -> begin
FStar_Pervasives_Native.Some ((Prims.parse_int "0"))
end
| T (c, a, uu___, b) -> begin
(

let hha = (black_height a)
in (

let hhb = (black_height b)
in (match (((hha), (hhb))) with
| (FStar_Pervasives_Native.Some (ha), FStar_Pervasives_Native.Some (hb)) -> begin
(match ((Prims.op_Equality ha hb)) with
| true -> begin
(match ((Prims.op_Equality c R)) with
| true -> begin
FStar_Pervasives_Native.Some (ha)
end
| uu___1 -> begin
FStar_Pervasives_Native.Some ((ha + (Prims.parse_int "1")))
end)
end
| uu___1 -> begin
FStar_Pervasives_Native.None
end)
end
| (uu___1, uu___2) -> begin
FStar_Pervasives_Native.None
end)))
end))


let rec min_elt : rbtree'  ->  Prims.nat = (fun ( uu___  :  rbtree' ) -> (match (uu___) with
| T (uu___1, a, x, uu___2) -> begin
(match (a) with
| E -> begin
x
end
| uu___3 -> begin
(min_elt a)
end)
end))


let rec max_elt : rbtree'  ->  Prims.nat = (fun ( uu___  :  rbtree' ) -> (match (uu___) with
| T (uu___1, uu___2, x, b) -> begin
(match (b) with
| E -> begin
x
end
| uu___3 -> begin
(max_elt b)
end)
end))


let r_inv : rbtree'  ->  Prims.bool = (fun ( t  :  rbtree' ) -> (Prims.op_Equality (color_of t) B))


let rec c_inv : rbtree'  ->  Prims.bool = (fun ( t  :  rbtree' ) -> (match (t) with
| E -> begin
true
end
| T (R, a, uu___, b) -> begin
((((Prims.op_Equality (color_of a) B) && (Prims.op_Equality (color_of b) B)) && (c_inv a)) && (c_inv b))
end
| T (B, a, uu___, b) -> begin
((c_inv a) && (c_inv b))
end))


let h_inv : rbtree'  ->  Prims.bool = (fun ( t  :  rbtree' ) -> (FStar_Pervasives_Native.uu___is_Some (black_height t)))


let rec k_inv : rbtree'  ->  Prims.bool = (fun ( t  :  rbtree' ) -> (match (t) with
| E -> begin
true
end
| T (uu___, E, x, E) -> begin
true
end
| T (uu___, E, x, b) -> begin
(

let b_min = (min_elt b)
in ((k_inv b) && (b_min > x)))
end
| T (uu___, a, x, E) -> begin
(

let a_max = (max_elt a)
in ((k_inv a) && (x > a_max)))
end
| T (uu___, a, x, b) -> begin
(

let a_max = (max_elt a)
in (

let b_min = (min_elt b)
in ((((k_inv a) && (k_inv b)) && (x > a_max)) && (b_min > x))))
end))


let rec in_tree : rbtree'  ->  Prims.nat  ->  Prims.bool = (fun ( t  :  rbtree' ) ( k  :  Prims.nat ) -> (match (t) with
| E -> begin
false
end
| T (uu___, a, x, b) -> begin
(((in_tree a k) || (Prims.op_Equality k x)) || (in_tree b k))
end))


type not_c_inv =
unit


type lr_c_inv =
unit


type pre_balance =
unit


type post_balance =
unit


let balance : color  ->  rbtree'  ->  Prims.nat  ->  rbtree'  ->  rbtree' = (fun ( c  :  color ) ( lt  :  rbtree' ) ( ky  :  Prims.nat ) ( rt  :  rbtree' ) -> (match (((c), (lt), (ky), (rt))) with
| (B, T (R, T (R, a, x, b), y, c1), z, d) -> begin
T (R, T (B, a, x, b), y, T (B, c1, z, d))
end
| (B, T (R, a, x, T (R, b, y, c1)), z, d) -> begin
T (R, T (B, a, x, b), y, T (B, c1, z, d))
end
| (B, a, x, T (R, T (R, b, y, c1), z, d)) -> begin
T (R, T (B, a, x, b), y, T (B, c1, z, d))
end
| (B, a, x, T (R, b, y, T (R, c1, z, d))) -> begin
T (R, T (B, a, x, b), y, T (B, c1, z, d))
end
| uu___ -> begin
T (c, lt, ky, rt)
end))


let rec ins : rbtree'  ->  Prims.nat  ->  rbtree' = (fun ( t  :  rbtree' ) ( x  :  Prims.nat ) -> (match (t) with
| E -> begin
T (R, E, x, E)
end
| T (c, a, y, b) -> begin
(match ((x < y)) with
| true -> begin
(

let lt = (ins a x)
in (balance c lt y b))
end
| uu___ -> begin
(match ((Prims.op_Equality x y)) with
| true -> begin
t
end
| uu___1 -> begin
(

let rt = (ins b x)
in (balance c a y rt))
end)
end)
end))


type balanced_rbtree' =
unit


let make_black : rbtree'  ->  rbtree' = (fun ( uu___  :  rbtree' ) -> (match (uu___) with
| T (uu___1, a, x, b) -> begin
T (B, a, x, b)
end))


let insert : rbtree'  ->  Prims.nat  ->  rbtree' = (fun ( t  :  rbtree' ) ( x  :  Prims.nat ) -> (

let r = (ins t x)
in (

let r' = (make_black r)
in r')))

type rbtree =
| Mk of rbtree'


let uu___is_Mk : rbtree  ->  Prims.bool = (fun ( projectee  :  rbtree ) -> true)


let __proj__Mk__item__tr : rbtree  ->  rbtree' = (fun ( projectee  :  rbtree ) -> (match (projectee) with
| Mk (tr) -> begin
tr
end))


let proj : rbtree  ->  rbtree' = (fun ( tr  :  rbtree ) -> (__proj__Mk__item__tr tr))




