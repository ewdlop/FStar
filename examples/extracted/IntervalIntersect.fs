#light "off"
module IntervalIntersect

type offset =
FStar_Int64.t

type interval =
| I of offset * offset


let uu___is_I : interval  ->  Prims.bool = (fun ( projectee  :  interval ) -> true)


let __proj__I__item__from : interval  ->  offset = (fun ( projectee  :  interval ) -> (match (projectee) with
| I (from, to1) -> begin
from
end))


let __proj__I__item__to : interval  ->  offset = (fun ( projectee  :  interval ) -> (match (projectee) with
| I (from, to1) -> begin
to1
end))


let rec goodLIs : interval Prims.list  ->  offset  ->  Prims.bool = (fun ( is  :  interval Prims.list ) ( lb  :  offset ) -> (match (is) with
| [] -> begin
true
end
| (I (f, t))::is1 -> begin
(((FStar_Int64.lte lb f) && (FStar_Int64.lt f t)) && (goodLIs is1 t))
end))


let good : interval Prims.list  ->  Prims.bool = (fun ( is  :  interval Prims.list ) -> (match (is) with
| [] -> begin
true
end
| (I (f, t))::uu___ -> begin
(goodLIs is f)
end))


type intervals =
interval Prims.list


let needs_reorder : intervals  ->  intervals  ->  Prims.nat = (fun ( is1  :  intervals ) ( is2  :  intervals ) -> (match (((is1), (is2))) with
| ((I (f1, t1))::uu___, (I (f2, t2))::uu___1) -> begin
(match ((FStar_Int64.lt t1 t2)) with
| true -> begin
(Prims.parse_int "1")
end
| uu___2 -> begin
(Prims.parse_int "0")
end)
end
| (uu___, uu___1) -> begin
(Prims.parse_int "0")
end))


let max : FStar_Int64.t  ->  FStar_Int64.t  ->  FStar_Int64.t = (fun ( a  :  FStar_Int64.t ) ( b  :  FStar_Int64.t ) -> (FStar_Int64.int_to_t (FStar_Math_Lib.max (FStar_Int64.v a) (FStar_Int64.v b))))


let rec go : intervals  ->  intervals  ->  intervals = (fun ( is1  :  intervals ) ( is2  :  intervals ) -> (match (((is1), (is2))) with
| (uu___, []) -> begin
[]
end
| ([], uu___) -> begin
[]
end
| ((i1)::is11, (i2)::is21) -> begin
(

let f' = (max (__proj__I__item__from i1) (__proj__I__item__from i2))
in (match ((FStar_Int64.lt (__proj__I__item__to i1) (__proj__I__item__to i2))) with
| true -> begin
(go ((i2)::is21) ((i1)::is11))
end
| uu___ -> begin
(match ((FStar_Int64.gte (__proj__I__item__from i1) (__proj__I__item__to i2))) with
| true -> begin
(go ((i1)::is11) is21)
end
| uu___1 -> begin
(match ((Prims.op_Equality (__proj__I__item__to i1) (__proj__I__item__to i2))) with
| true -> begin
(I (f', (__proj__I__item__to i1)))::(go is11 is21)
end
| uu___2 -> begin
(I (f', (__proj__I__item__to i2)))::(go ((I ((__proj__I__item__to i2), (__proj__I__item__to i1)))::is11) is21)
end)
end)
end))
end))


let intersect : intervals  ->  intervals  ->  intervals = (fun ( is1  :  intervals ) ( is2  :  intervals ) -> (go is1 is2))


let rec range : offset  ->  offset  ->  offset FStar_Set.set = (fun ( f  :  offset ) ( t  :  offset ) -> (match ((FStar_Int64.gte f t)) with
| true -> begin
(FStar_Set.empty ())
end
| uu___ -> begin
(FStar_Set.union (FStar_Set.singleton f) (range (FStar_Int64.add f (FStar_Int64.int_to_t (Prims.parse_int "1"))) t))
end))


let semI : interval  ->  offset FStar_Set.set = (fun ( i  :  interval ) -> (range (__proj__I__item__from i) (__proj__I__item__to i)))


let rec sem : intervals  ->  offset FStar_Set.set = (fun ( is  :  intervals ) -> (match (is) with
| [] -> begin
(FStar_Set.empty ())
end
| (i)::is1 -> begin
(FStar_Set.union (semI i) (sem is1))
end))


let ppInterval : interval  ->  Prims.string = (fun ( uu___  :  interval ) -> (match (uu___) with
| I (f, t) -> begin
(Prims.strcat (Prims.strcat "0x" (Prims.strcat (Prims.string_of_int (FStar_Int64.v f)) "-0x")) (Prims.strcat (Prims.string_of_int (FStar_Int64.v t)) ""))
end))


let rec ppIntervals' : intervals  ->  unit = (fun ( is  :  intervals ) -> (match (is) with
| [] -> begin
(FStar_IO.print_string ".")
end
| (i)::is1 -> begin
((FStar_IO.print_string (ppInterval i));
(FStar_IO.print_string " ");
(ppIntervals' is1);
)
end))


let toI : FStar_Int.int_t  ->  FStar_Int.int_t  ->  interval = (fun ( f  :  FStar_Int.int_t ) ( t  :  FStar_Int.int_t ) -> I ((FStar_Int64.int_to_t f), (FStar_Int64.int_to_t t)))


let ppIntervals : interval Prims.list  ->  Prims.string = (fun ( is  :  interval Prims.list ) -> (

let uu___ = (FStar_List.map ppInterval is)
in (FStar_List_Tot_Base.fold_left (fun ( x  :  Prims.string ) ( x1  :  Prims.string ) -> (Prims.strcat (Prims.strcat "" (Prims.strcat x " ")) (Prims.strcat x1 ""))) "" uu___)))


let main : unit = ((

let uu___1 = (ppIntervals (intersect (((toI (Prims.parse_int "3") (Prims.parse_int "10")))::((toI (Prims.parse_int "10") (Prims.parse_int "15")))::[]) (((toI (Prims.parse_int "1") (Prims.parse_int "4")))::((toI (Prims.parse_int "10") (Prims.parse_int "14")))::[])))
in (FStar_IO.print_string uu___1));
(FStar_IO.print_newline ());
)




