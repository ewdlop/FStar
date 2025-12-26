#light "off"
module FStar_Class_Eq

type decides_eq =
unit

type 'a deq =
{raw : 'a FStar_Class_Eq_Raw.deq; eq_dec : unit}


let __proj__Mkdeq__item__raw = (fun ( projectee  :  'a deq ) -> (match (projectee) with
| {raw = raw; eq_dec = eq_dec} -> begin
raw
end))


let raw = (fun ( projectee  :  'a deq ) -> (match (projectee) with
| {raw = raw1; eq_dec = eq_dec} -> begin
raw1
end))


let deq_raw_deq = (fun ( d  :  'a deq ) -> d.raw)


let eq = (fun ( d  :  'a deq ) ( x  :  'a ) ( y  :  'a ) -> (d.raw.eq x y))


let eq_instance_of_eqtype = (fun ( uu___  :  'a FStar_Class_Eq_Raw.deq ) -> {raw = (FStar_Class_Eq_Raw.eq_instance_of_eqtype ()); eq_dec = ()})


let int_has_eq : Prims.int deq = (eq_instance_of_eqtype FStar_Class_Eq_Raw.int_has_eq)


let unit_has_eq : unit deq = (eq_instance_of_eqtype FStar_Class_Eq_Raw.unit_has_eq)


let bool_has_eq : Prims.bool deq = (eq_instance_of_eqtype FStar_Class_Eq_Raw.bool_has_eq)


let string_has_eq : Prims.string deq = (eq_instance_of_eqtype FStar_Class_Eq_Raw.string_has_eq)


let eq_list = (fun ( d  :  'a deq ) -> {raw = (FStar_Class_Eq_Raw.eq_list d.raw); eq_dec = ()})


let eq_pair = (fun ( uu___  :  'a deq ) ( uu___1  :  'b deq ) -> {raw = (FStar_Class_Eq_Raw.eq_pair (deq_raw_deq uu___) (deq_raw_deq uu___1)); eq_dec = ()})


let eq_option = (fun ( uu___  :  'a deq ) -> {raw = (FStar_Class_Eq_Raw.eq_option (deq_raw_deq uu___)); eq_dec = ()})


let op_Equals = eq




