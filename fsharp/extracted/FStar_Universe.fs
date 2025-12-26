#light "off"
module FStar_Universe
type 'a raise0 =
| Ret of 'a


let uu___is_Ret = (fun ( projectee  :  'a raise0 ) -> true)


let __proj__Ret__item___0 = (fun ( projectee  :  'a raise0 ) -> (match (projectee) with
| Ret (_0) -> begin
_0
end))


type 'a raise_t =
'a raise0


let raise_val = (fun ( x  :  'a ) -> Ret (x))


let downgrade_val = (fun ( x  :  'a raise_t ) -> (match (x) with
| Ret (x0) -> begin
x0
end))


let lift_dom = (fun ( q  :  'a  ->  'b ) ( v  :  'a raise_t ) -> (q (downgrade_val v)))


let lift_codom = (fun ( q  :  'a  ->  'b ) ( v  :  'a ) -> (raise_val (q v)))




