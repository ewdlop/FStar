#light "off"
module FStar_Monotonic_Pure

type is_monotonic =
unit


type 'wp as_pure_wp =
'wp


let elim_pure = (fun ( f  :  unit  ->  'a ) ( p  :  unit ) -> (f ()))




