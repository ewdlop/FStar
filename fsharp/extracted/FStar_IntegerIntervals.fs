#light "off"
module FStar_IntegerIntervals

type less_than =
Prims.int


type greater_than =
Prims.int


type not_less_than =
greater_than


type not_greater_than =
less_than


let coerce_to_less_than : Prims.int  ->  not_greater_than  ->  less_than = (fun ( n  :  Prims.int ) ( x  :  not_greater_than ) -> x)


let coerce_to_not_less_than : Prims.int  ->  greater_than  ->  not_less_than = (fun ( n  :  Prims.int ) ( x  :  greater_than ) -> x)


let interval_condition : Prims.int  ->  Prims.int  ->  Prims.int  ->  Prims.bool = (fun ( x  :  Prims.int ) ( y  :  Prims.int ) ( t  :  Prims.int ) -> ((x <= t) && (t < y)))


type interval_type =
unit


type interval =
Prims.int


type efrom_eto =
interval


type efrom_ito =
interval


type ifrom_eto =
interval


type ifrom_ito =
interval


type under =
interval


let interval_size : Prims.int  ->  Prims.int  ->  unit  ->  Prims.nat = (fun ( x  :  Prims.int ) ( y  :  Prims.int ) ( interval1  :  unit ) -> (match ((y >= x)) with
| true -> begin
(y - x)
end
| uu___ -> begin
(Prims.parse_int "0")
end))


type counter_for =
under


let closed_interval_size : Prims.int  ->  Prims.int  ->  Prims.nat = (fun ( x  :  Prims.int ) ( y  :  Prims.int ) -> (interval_size x (y + (Prims.parse_int "1")) ()))


let indices_seq : Prims.nat  ->  under FStar_Seq_Base.seq = (fun ( n  :  Prims.nat ) -> (FStar_Seq_Base.init n (fun ( x  :  under ) -> x)))




