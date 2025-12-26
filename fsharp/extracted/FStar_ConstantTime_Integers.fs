#light "off"
module FStar_ConstantTime_Integers

type sw =
FStar_Integers.signed_width



let promote : unit  ->  unit  ->  sw  ->  (obj, obj, obj) secret_int  ->  unit  ->  (obj, obj, obj) secret_int = (fun ( sl  :  unit ) ( l0  :  unit ) ( s  :  sw ) ( x  :  (obj, obj, obj) secret_int ) ( l1  :  unit ) -> (FStar_IFC.join () () () () (Prims.unsafe_coerce (FStar_IFC.hide () () () (Prims.unsafe_coerce x)))))

type qual =
| Secret of unit * unit * sw
| Public of FStar_Integers.signed_width


let uu___is_Secret : qual  ->  Prims.bool = (fun ( projectee  :  qual ) -> (match (projectee) with
| Secret (sl, l, sw1) -> begin
true
end
| uu___ -> begin
false
end))








let __proj__Secret__item__sw : qual  ->  sw = (fun ( projectee  :  qual ) -> (match (projectee) with
| Secret (sl, l, sw1) -> begin
sw1
end))


let uu___is_Public : qual  ->  Prims.bool = (fun ( projectee  :  qual ) -> (match (projectee) with
| Public (sw1) -> begin
true
end
| uu___ -> begin
false
end))


let __proj__Public__item__sw : qual  ->  FStar_Integers.signed_width = (fun ( projectee  :  qual ) -> (match (projectee) with
| Public (sw1) -> begin
sw1
end))


let sw_qual : qual  ->  FStar_Integers.signed_width = (fun ( uu___  :  qual ) -> (match (uu___) with
| Secret (uu___1, uu___2, sw1) -> begin
sw1
end
| Public (sw1) -> begin
sw1
end))





type t =
obj


let as_secret : qual  ->  obj  ->  (obj, obj, obj) secret_int = (fun ( uu___1  :  qual ) ( uu___  :  obj ) -> ((fun ( q  :  qual ) ( x  :  obj ) -> (Prims.unsafe_coerce x)) uu___1 uu___))


let as_public : qual  ->  obj  ->  obj = (fun ( q  :  qual ) ( x  :  obj ) -> x)




