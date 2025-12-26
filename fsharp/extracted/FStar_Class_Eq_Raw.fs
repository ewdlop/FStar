#light "off"
module FStar_Class_Eq_Raw
type 'a deq =
{eq : 'a  ->  'a  ->  Prims.bool}


let __proj__Mkdeq__item__eq = (fun ( projectee  :  'a deq ) -> (match (projectee) with
| {eq = eq} -> begin
eq
end))


let eq = (fun ( projectee  :  'a deq ) -> (match (projectee) with
| {eq = eq1} -> begin
eq1
end))


let eq_instance_of_eqtype = (fun ( uu___  :  unit ) -> {eq = (fun ( x  :  'a ) ( y  :  'a ) -> (Prims.op_Equality x y))})


let int_has_eq : Prims.int deq = (eq_instance_of_eqtype ())


let unit_has_eq : unit deq = (eq_instance_of_eqtype ())


let bool_has_eq : Prims.bool deq = (eq_instance_of_eqtype ())


let string_has_eq : Prims.string deq = (eq_instance_of_eqtype ())


let rec eqList = (fun ( eq1  :  'a  ->  'a  ->  Prims.bool ) ( xs  :  'a Prims.list ) ( ys  :  'a Prims.list ) -> (match (((xs), (ys))) with
| ([], []) -> begin
true
end
| ((x)::xs1, (y)::ys1) -> begin
((eq1 x y) && (eqList eq1 xs1 ys1))
end
| (uu___, uu___1) -> begin
false
end))


let eq_list = (fun ( uu___  :  'a deq ) -> {eq = (eqList (eq uu___))})


let eq_pair = (fun ( uu___  :  'a deq ) ( uu___1  :  'b deq ) -> {eq = (fun ( uu___2  :  ('a * 'b) ) ( uu___3  :  ('a * 'b) ) -> (match (((uu___2), (uu___3))) with
| ((a1, b1), (c, d)) -> begin
((eq uu___ a1 c) && (eq uu___1 b1 d))
end))})


let eq_option = (fun ( uu___  :  'a deq ) -> {eq = (fun ( o1  :  'a FStar_Pervasives_Native.option ) ( o2  :  'a FStar_Pervasives_Native.option ) -> (match (((o1), (o2))) with
| (FStar_Pervasives_Native.None, FStar_Pervasives_Native.None) -> begin
true
end
| (FStar_Pervasives_Native.Some (x), FStar_Pervasives_Native.Some (y)) -> begin
(eq uu___ x y)
end
| (uu___1, uu___2) -> begin
false
end))})


let eq_either = (fun ( uu___  :  'a deq ) ( uu___1  :  'b deq ) -> {eq = (fun ( x  :  ('a, 'b) FStar_Pervasives.either ) ( y  :  ('a, 'b) FStar_Pervasives.either ) -> (match (((x), (y))) with
| (FStar_Pervasives.Inl (a1), FStar_Pervasives.Inl (a2)) -> begin
(eq uu___ a1 a2)
end
| (FStar_Pervasives.Inr (b1), FStar_Pervasives.Inr (b2)) -> begin
(eq uu___1 b1 b2)
end
| (uu___2, uu___3) -> begin
false
end))})


let op_Equals = eq




