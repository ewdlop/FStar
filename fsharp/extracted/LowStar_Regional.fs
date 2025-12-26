#light "off"
module LowStar_Regional
type ('st, 'a) regional =
| Rgl of 'st * unit * unit * 'a * unit * unit * unit * unit * unit * unit * unit * ('st  ->  unit  ->  'a) * ('st  ->  'a  ->  unit)


let uu___is_Rgl = (fun ( projectee  :  ('st, 'a) regional ) -> true)


let __proj__Rgl__item__state = (fun ( projectee  :  ('st, 'a) regional ) -> (match (projectee) with
| Rgl (state, region_of, loc_of, dummy, r_inv, r_inv_reg, repr, r_repr, r_sep, irepr, r_alloc_p, r_alloc, r_free) -> begin
state
end))


let __proj__Rgl__item__dummy = (fun ( projectee  :  ('st, 'a) regional ) -> (match (projectee) with
| Rgl (state, region_of, loc_of, dummy, r_inv, r_inv_reg, repr, r_repr, r_sep, irepr, r_alloc_p, r_alloc, r_free) -> begin
dummy
end))


let __proj__Rgl__item__r_alloc = (fun ( projectee  :  ('st, 'a) regional ) -> (match (projectee) with
| Rgl (state, region_of, loc_of, dummy, r_inv, r_inv_reg, repr, r_repr, r_sep, irepr, r_alloc_p, r_alloc, r_free) -> begin
r_alloc
end))


let __proj__Rgl__item__r_free = (fun ( projectee  :  ('st, 'a) regional ) -> (match (projectee) with
| Rgl (state, region_of, loc_of, dummy, r_inv, r_inv_reg, repr, r_repr, r_sep, irepr, r_alloc_p, r_alloc, r_free) -> begin
r_free
end))


type rg_inv =
obj


let rg_dummy = (fun ( rg  :  ('rst, 'a) regional ) -> (__proj__Rgl__item__dummy rg))


let rg_alloc = (fun ( rg  :  ('rst, 'a) regional ) ( r  :  unit ) -> (__proj__Rgl__item__r_alloc rg (__proj__Rgl__item__state rg) ()))


let rg_free = (fun ( rg  :  ('rst, 'a) regional ) ( v  :  'a ) -> (__proj__Rgl__item__r_free rg (__proj__Rgl__item__state rg) v))




