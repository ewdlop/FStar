#light "off"
module FStar_Class_TotalOrder_Raw

let flip : FStar_Order.order  ->  FStar_Order.order = (fun ( uu___  :  FStar_Order.order ) -> (match (uu___) with
| FStar_Order.Lt -> begin
FStar_Order.Gt
end
| FStar_Order.Eq -> begin
FStar_Order.Eq
end
| FStar_Order.Gt -> begin
FStar_Order.Lt
end))


type 'a raw_comparator =
'a  ->  'a  ->  FStar_Order.order

type 'a totalorder =
{compare : 'a raw_comparator}


let __proj__Mktotalorder__item__compare = (fun ( projectee  :  'a totalorder ) -> (match (projectee) with
| {compare = compare} -> begin
compare
end))


let compare = (fun ( projectee  :  'a totalorder ) -> (match (projectee) with
| {compare = compare1} -> begin
compare1
end))


let op_Less = (fun ( uu___  :  't totalorder ) ( x  :  't ) ( y  :  't ) -> (Prims.op_Equality (compare uu___ x y) FStar_Order.Lt))


let op_Greater = (fun ( uu___  :  't totalorder ) ( x  :  't ) ( y  :  't ) -> (Prims.op_Equality (compare uu___ x y) FStar_Order.Gt))


let op_Equals = (fun ( uu___  :  't totalorder ) ( x  :  't ) ( y  :  't ) -> (Prims.op_Equality (compare uu___ x y) FStar_Order.Eq))


let op_Less_Equals = (fun ( uu___  :  't totalorder ) ( x  :  't ) ( y  :  't ) -> (Prims.op_disEquality (compare uu___ x y) FStar_Order.Gt))


let op_Greater_Equals = (fun ( uu___  :  't totalorder ) ( x  :  't ) ( y  :  't ) -> (Prims.op_disEquality (compare uu___ x y) FStar_Order.Lt))


let op_Less_Greater = (fun ( uu___  :  't totalorder ) ( x  :  't ) ( y  :  't ) -> (Prims.op_disEquality (compare uu___ x y) FStar_Order.Eq))


let uu___0 : Prims.int totalorder = {compare = FStar_Order.compare_int}


let uu___1 : Prims.bool totalorder = {compare = (fun ( b1  :  Prims.bool ) ( b2  :  Prims.bool ) -> (match (((b1), (b2))) with
| (false, false) -> begin
FStar_Order.Eq
end
| (true, true) -> begin
FStar_Order.Eq
end
| (false, uu___) -> begin
FStar_Order.Lt
end
| uu___ -> begin
FStar_Order.Gt
end))}


let totalorder_pair = (fun ( d1  :  'a totalorder ) ( d2  :  'b totalorder ) -> {compare = (fun ( uu___  :  ('a * 'b) ) ( uu___2  :  ('a * 'b) ) -> (match (((uu___), (uu___2))) with
| ((xa, xb), (ya, yb)) -> begin
(match ((compare d1 xa ya)) with
| FStar_Order.Lt -> begin
FStar_Order.Lt
end
| FStar_Order.Gt -> begin
FStar_Order.Gt
end
| FStar_Order.Eq -> begin
(compare d2 xb yb)
end)
end))})


let totalorder_option = (fun ( d  :  'a totalorder ) -> {compare = (fun ( o1  :  'a FStar_Pervasives_Native.option ) ( o2  :  'a FStar_Pervasives_Native.option ) -> (match (((o1), (o2))) with
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.None) -> begin
FStar_Order.Eq
end
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.Some (uu___)) -> begin
FStar_Order.Lt
end
| (FStar_Pervasives_Native.Some (uu___), FStar_Pervasives_Native.None) -> begin
FStar_Order.Gt
end
| (FStar_Pervasives_Native.Some (a1), FStar_Pervasives_Native.Some (a2)) -> begin
(compare d a1 a2)
end))})


let rec raw_compare_lists = (fun ( d  :  'a totalorder ) ( l1  :  'a Prims.list ) ( l2  :  'a Prims.list ) -> (match (((l1), (l2))) with
| ([], []) -> begin
FStar_Order.Eq
end
| ([], (uu___)::uu___2) -> begin
FStar_Order.Lt
end
| ((uu___)::uu___2, []) -> begin
FStar_Order.Gt
end
| ((x)::xs, (y)::ys) -> begin
(match ((compare d x y)) with
| FStar_Order.Lt -> begin
FStar_Order.Lt
end
| FStar_Order.Gt -> begin
FStar_Order.Gt
end
| FStar_Order.Eq -> begin
(raw_compare_lists d xs ys)
end)
end))


let totalorder_list = (fun ( d  :  'a totalorder ) -> {compare = (raw_compare_lists d)})




