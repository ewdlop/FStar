#light "off"
module BinarySearchTreeFirst
type 'r tree =
| Node of Prims.int * obj tree FStar_Pervasives_Native.option * Prims.int * 'r tree FStar_Pervasives_Native.option


let uu___is_Node : Prims.int  ->  obj tree  ->  Prims.bool = (fun ( r  :  Prims.int ) ( projectee  :  obj tree ) -> true)


let __proj__Node__item__l : Prims.int  ->  obj tree  ->  Prims.int = (fun ( r  :  Prims.int ) ( projectee  :  obj tree ) -> (match (projectee) with
| Node (l, left, n, right) -> begin
l
end))


let __proj__Node__item__left : Prims.int  ->  obj tree  ->  obj tree FStar_Pervasives_Native.option = (fun ( r  :  Prims.int ) ( projectee  :  obj tree ) -> (match (projectee) with
| Node (l, left, n, right) -> begin
left
end))


let __proj__Node__item__n : Prims.int  ->  obj tree  ->  Prims.int = (fun ( r  :  Prims.int ) ( projectee  :  obj tree ) -> (match (projectee) with
| Node (l, left, n, right) -> begin
n
end))


let __proj__Node__item__right : Prims.int  ->  obj tree  ->  obj tree FStar_Pervasives_Native.option = (fun ( r  :  Prims.int ) ( projectee  :  obj tree ) -> (match (projectee) with
| Node (l, left, n, right) -> begin
right
end))


let leaf : Prims.int  ->  obj tree = (fun ( i  :  Prims.int ) -> Node (i, FStar_Pervasives_Native.None, i, FStar_Pervasives_Native.None))


let max : Prims.int  ->  Prims.int  ->  Prims.int = (fun ( i  :  Prims.int ) ( j  :  Prims.int ) -> (match ((i < j)) with
| true -> begin
j
end
| uu___ -> begin
i
end))


let rec insert : Prims.int  ->  obj tree  ->  Prims.int  ->  obj tree = (fun ( k  :  Prims.int ) ( uu___  :  obj tree ) ( i  :  Prims.int ) -> (match (uu___) with
| Node (uu___1, left, n, right) -> begin
(match ((Prims.op_Equality i n)) with
| true -> begin
Node (uu___1, left, n, right)
end
| uu___2 -> begin
(match ((i < n)) with
| true -> begin
(match (left) with
| FStar_Pervasives_Native.None -> begin
Node (i, FStar_Pervasives_Native.Some ((leaf i)), n, right)
end
| FStar_Pervasives_Native.Some (left1) -> begin
Node ((max uu___1 i), FStar_Pervasives_Native.Some ((insert uu___1 left1 i)), n, right)
end)
end
| uu___3 -> begin
(match (right) with
| FStar_Pervasives_Native.None -> begin
Node (uu___1, left, n, FStar_Pervasives_Native.Some ((leaf i)))
end
| FStar_Pervasives_Native.Some (right1) -> begin
Node (uu___1, left, n, FStar_Pervasives_Native.Some ((insert k right1 i)))
end)
end)
end)
end))


let rec contains : Prims.int  ->  obj tree  ->  Prims.int  ->  Prims.bool = (fun ( k  :  Prims.int ) ( t  :  obj tree ) ( key  :  Prims.int ) -> (match ((key > k)) with
| true -> begin
false
end
| uu___ -> begin
(

let uu___1 = t
in (match (uu___1) with
| Node (uu___2, left, i, right) -> begin
(((Prims.op_Equality i k) || (((key < i) && (FStar_Pervasives_Native.uu___is_Some left)) && (contains uu___2 (FStar_Pervasives_Native.__proj__Some__item__v left) key))) || ((FStar_Pervasives_Native.uu___is_Some right) && (contains k (FStar_Pervasives_Native.__proj__Some__item__v right) key)))
end))
end))


let rec in_order_opt : Prims.int  ->  obj tree FStar_Pervasives_Native.option  ->  Prims.int Prims.list = (fun ( k  :  Prims.int ) ( t  :  obj tree FStar_Pervasives_Native.option ) -> (match (t) with
| FStar_Pervasives_Native.None -> begin
[]
end
| FStar_Pervasives_Native.Some (Node (uu___, left, i, right)) -> begin
(FStar_List_Tot_Base.op_At (in_order_opt uu___ left) (FStar_List_Tot_Base.op_At ((i)::[]) (in_order_opt k right)))
end))


type t =
(Prims.int, obj tree) Prims.dtuple2


let ins : t  ->  Prims.int  ->  t = (fun ( uu___  :  t ) ( n  :  Prims.int ) -> (match (uu___) with
| Prims.Mkdtuple2 (m, tt) -> begin
Prims.Mkdtuple2 ((max m n), (insert m tt n))
end))




