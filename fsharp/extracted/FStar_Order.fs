#light "off"
module FStar_Order
type order =
| Lt
| Eq
| Gt


let uu___is_Lt : order  ->  Prims.bool = (fun ( projectee  :  order ) -> (match (projectee) with
| Lt -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Eq : order  ->  Prims.bool = (fun ( projectee  :  order ) -> (match (projectee) with
| Eq -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Gt : order  ->  Prims.bool = (fun ( projectee  :  order ) -> (match (projectee) with
| Gt -> begin
true
end
| uu___ -> begin
false
end))


let ge : order  ->  Prims.bool = (fun ( o  :  order ) -> (Prims.op_disEquality o Lt))


let le : order  ->  Prims.bool = (fun ( o  :  order ) -> (Prims.op_disEquality o Gt))


let ne : order  ->  Prims.bool = (fun ( o  :  order ) -> (Prims.op_disEquality o Eq))


let gt : order  ->  Prims.bool = (fun ( o  :  order ) -> (Prims.op_Equality o Gt))


let lt : order  ->  Prims.bool = (fun ( o  :  order ) -> (Prims.op_Equality o Lt))


let eq : order  ->  Prims.bool = (fun ( o  :  order ) -> (Prims.op_Equality o Eq))


let lex : order  ->  (unit  ->  order)  ->  order = (fun ( o1  :  order ) ( o2  :  unit  ->  order ) -> (match (o1) with
| Lt -> begin
Lt
end
| Eq -> begin
(o2 ())
end
| Gt -> begin
Gt
end))


let order_from_int : Prims.int  ->  order = (fun ( i  :  Prims.int ) -> (match ((i < (Prims.parse_int "0"))) with
| true -> begin
Lt
end
| uu___ -> begin
(match ((Prims.op_Equality i (Prims.parse_int "0"))) with
| true -> begin
Eq
end
| uu___1 -> begin
Gt
end)
end))


let int_of_order : order  ->  Prims.int = (fun ( uu___  :  order ) -> (match (uu___) with
| Lt -> begin
(Prims.parse_int "-1")
end
| Eq -> begin
(Prims.parse_int "0")
end
| Gt -> begin
(Prims.parse_int "1")
end))


let compare_int : Prims.int  ->  Prims.int  ->  order = (fun ( i  :  Prims.int ) ( j  :  Prims.int ) -> (order_from_int (i - j)))


let rec compare_list = (fun ( l1  :  'a Prims.list ) ( l2  :  'a Prims.list ) ( f  :  'a  ->  'a  ->  order ) -> (match (((l1), (l2))) with
| ([], []) -> begin
Eq
end
| ([], uu___) -> begin
Lt
end
| (uu___, []) -> begin
Gt
end
| ((x)::xs, (y)::ys) -> begin
(lex (f x y) (fun ( uu___  :  unit ) -> (compare_list xs ys f)))
end))


let compare_option = (fun ( f  :  'a  ->  'a  ->  order ) ( x  :  'a FStar_Pervasives_Native.option ) ( y  :  'a FStar_Pervasives_Native.option ) -> (match (((x), (y))) with
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.None) -> begin
Eq
end
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.Some (uu___)) -> begin
Lt
end
| (FStar_Pervasives_Native.Some (uu___), FStar_Pervasives_Native.None) -> begin
Gt
end
| (FStar_Pervasives_Native.Some (x1), FStar_Pervasives_Native.Some (y1)) -> begin
(f x1 y1)
end))




