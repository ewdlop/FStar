#light "off"
module FStar_Class_Ord_Raw
type 'a ord =
{super : 'a FStar_Class_Eq_Raw.deq; cmp : 'a  ->  'a  ->  FStar_Order.order}


let __proj__Mkord__item__super = (fun ( projectee  :  'a ord ) -> (match (projectee) with
| {super = super; cmp = cmp} -> begin
super
end))


let __proj__Mkord__item__cmp = (fun ( projectee  :  'a ord ) -> (match (projectee) with
| {super = super; cmp = cmp} -> begin
cmp
end))


let super = (fun ( projectee  :  'a ord ) -> (match (projectee) with
| {super = super1; cmp = cmp} -> begin
super1
end))


let cmp = (fun ( projectee  :  'a ord ) -> (match (projectee) with
| {super = super1; cmp = cmp1} -> begin
cmp1
end))


let ord_eq = (fun ( d  :  'a ord ) -> d.super)


let op_Less_Question = (fun ( uu___  :  'a ord ) ( x  :  'a ) ( y  :  'a ) -> (FStar_Order.uu___is_Lt (cmp uu___ x y)))


let op_Greater_Question = (fun ( uu___  :  'a ord ) ( x  :  'a ) ( y  :  'a ) -> (FStar_Order.uu___is_Gt (cmp uu___ x y)))


let op_Less_Equals_Question = (fun ( uu___  :  'a ord ) ( x  :  'a ) ( y  :  'a ) -> (not ((op_Greater_Question uu___ x y))))


let op_Greater_Equals_Question = (fun ( uu___  :  'a ord ) ( x  :  'a ) ( y  :  'a ) -> (not ((op_Less_Question uu___ x y))))


let min = (fun ( uu___  :  'a ord ) ( x  :  'a ) ( y  :  'a ) -> (match ((op_Less_Equals_Question uu___ x y)) with
| true -> begin
x
end
| uu___1 -> begin
y
end))


let max = (fun ( uu___  :  'a ord ) ( x  :  'a ) ( y  :  'a ) -> (match ((op_Greater_Equals_Question uu___ x y)) with
| true -> begin
x
end
| uu___1 -> begin
y
end))


let rec sort = (fun ( uu___  :  'a ord ) ( xs  :  'a Prims.list ) -> (

let rec insert : 'a  ->  'a Prims.list  ->  'a Prims.list = (fun ( x  :  'a ) ( xs1  :  'a Prims.list ) -> (match (xs1) with
| [] -> begin
(x)::[]
end
| (y)::ys -> begin
(match ((op_Less_Equals_Question uu___ x y)) with
| true -> begin
(x)::(y)::ys
end
| uu___1 -> begin
(y)::(insert x ys)
end)
end))
in (match (xs) with
| [] -> begin
[]
end
| (x)::xs1 -> begin
(insert x (sort uu___ xs1))
end)))


let sort_by = (fun ( f  :  'a  ->  'a  ->  FStar_Order.order ) ( xs  :  'a Prims.list ) -> (

let d = {super = {FStar_Class_Eq_Raw.eq = (fun ( a1  :  'a ) ( b  :  'a ) -> (Prims.op_Equality (f a1 b) FStar_Order.Eq))}; cmp = f}
in (sort d xs)))


let dedup = (fun ( uu___  :  'a ord ) ( xs  :  'a Prims.list ) -> (

let out = (FStar_List_Tot_Base.fold_left (fun ( out1  :  'a Prims.list ) ( x  :  'a ) -> (match ((FStar_List_Tot_Base.existsb (fun ( y  :  'a ) -> (FStar_Class_Eq_Raw.op_Equals (ord_eq uu___) x y)) out1)) with
| true -> begin
out1
end
| uu___1 -> begin
(x)::out1
end)) [] xs)
in (FStar_List_Tot_Base.rev out)))


let rec insert_nodup = (fun ( uu___  :  'a ord ) ( x  :  'a ) ( xs  :  'a Prims.list ) -> (match (xs) with
| [] -> begin
(x)::[]
end
| (y)::ys -> begin
(match ((cmp uu___ x y)) with
| FStar_Order.Eq -> begin
xs
end
| FStar_Order.Lt -> begin
(x)::xs
end
| FStar_Order.Gt -> begin
(y)::(insert_nodup uu___ x ys)
end)
end))


let rec sort_dedup = (fun ( uu___  :  'a ord ) ( xs  :  'a Prims.list ) -> (match (xs) with
| [] -> begin
[]
end
| (x)::xs1 -> begin
(insert_nodup uu___ x (sort_dedup uu___ xs1))
end))


let ord_list_diff = (fun ( uu___  :  'a ord ) ( xs  :  'a Prims.list ) ( ys  :  'a Prims.list ) -> (

let xs1 = (sort_dedup uu___ xs)
in (

let ys1 = (sort_dedup uu___ ys)
in (

let rec go : 'a Prims.list  ->  'a Prims.list  ->  'a Prims.list  ->  'a Prims.list  ->  ('a Prims.list * 'a Prims.list) = (fun ( xd  :  'a Prims.list ) ( yd  :  'a Prims.list ) ( xs2  :  'a Prims.list ) ( ys2  :  'a Prims.list ) -> (match (((xs2), (ys2))) with
| ((x)::xs3, (y)::ys3) -> begin
(match ((cmp uu___ x y)) with
| FStar_Order.Lt -> begin
(go ((x)::xd) yd xs3 ((y)::ys3))
end
| FStar_Order.Eq -> begin
(go xd yd xs3 ys3)
end
| FStar_Order.Gt -> begin
(go xd ((y)::yd) ((x)::xs3) ys3)
end)
end
| (xs3, ys3) -> begin
(((FStar_List_Tot_Base.rev_acc xd xs3)), ((FStar_List_Tot_Base.rev_acc yd ys3)))
end))
in (go [] [] xs1 ys1)))))


let ord_int : Prims.int ord = {super = FStar_Class_Eq_Raw.int_has_eq; cmp = FStar_Order.compare_int}


let ord_unit : unit ord = {super = FStar_Class_Eq_Raw.unit_has_eq; cmp = (fun ( uu___  :  unit ) ( uu___1  :  unit ) -> FStar_Order.Eq)}


let ord_string : Prims.string ord = {super = FStar_Class_Eq_Raw.string_has_eq; cmp = (fun ( x  :  Prims.string ) ( y  :  Prims.string ) -> (FStar_Order.order_from_int (FStar_String.compare x y)))}


let ord_option = (fun ( d  :  'a ord ) -> {super = (FStar_Class_Eq_Raw.eq_option (ord_eq d)); cmp = (fun ( x  :  'a FStar_Pervasives_Native.option ) ( y  :  'a FStar_Pervasives_Native.option ) -> (match (((x), (y))) with
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.None) -> begin
FStar_Order.Eq
end
| (FStar_Pervasives_Native.Some (uu___), FStar_Pervasives_Native.None) -> begin
FStar_Order.Gt
end
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.Some (uu___)) -> begin
FStar_Order.Lt
end
| (FStar_Pervasives_Native.Some (x1), FStar_Pervasives_Native.Some (y1)) -> begin
(cmp d x1 y1)
end))})


let ord_list = (fun ( d  :  'a ord ) -> {super = (FStar_Class_Eq_Raw.eq_list (ord_eq d)); cmp = (fun ( l1  :  'a Prims.list ) ( l2  :  'a Prims.list ) -> (FStar_Order.compare_list l1 l2 (cmp d)))})


let ord_either = (fun ( d1  :  'a ord ) ( d2  :  'b ord ) -> {super = (FStar_Class_Eq_Raw.eq_either (ord_eq d1) (ord_eq d2)); cmp = (fun ( x  :  ('a, 'b) FStar_Pervasives.either ) ( y  :  ('a, 'b) FStar_Pervasives.either ) -> (match (((x), (y))) with
| (FStar_Pervasives.Inl (uu___), FStar_Pervasives.Inr (uu___1)) -> begin
FStar_Order.Lt
end
| (FStar_Pervasives.Inr (uu___), FStar_Pervasives.Inl (uu___1)) -> begin
FStar_Order.Gt
end
| (FStar_Pervasives.Inl (x1), FStar_Pervasives.Inl (y1)) -> begin
(cmp d1 x1 y1)
end
| (FStar_Pervasives.Inr (x1), FStar_Pervasives.Inr (y1)) -> begin
(cmp d2 x1 y1)
end))})


let ord_tuple2 = (fun ( d1  :  'a ord ) ( d2  :  'b ord ) -> {super = (FStar_Class_Eq_Raw.eq_pair (ord_eq d1) (ord_eq d2)); cmp = (fun ( uu___  :  ('a * 'b) ) ( uu___1  :  ('a * 'b) ) -> (match (((uu___), (uu___1))) with
| ((x1, x2), (y1, y2)) -> begin
(FStar_Order.lex (cmp d1 x1 y1) (fun ( uu___2  :  unit ) -> (cmp d2 x2 y2)))
end))})




