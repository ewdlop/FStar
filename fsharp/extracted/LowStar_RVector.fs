#light "off"
module LowStar_RVector
type ('rst, 'a, 'rg) copyable =
| Cpy of ('rst  ->  'a  ->  'a  ->  unit)


let uu___is_Cpy = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( projectee  :  ('rst, 'a, obj) copyable ) -> true)


let __proj__Cpy__item__copy = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( projectee  :  ('rst, 'a, obj) copyable ) -> (match (projectee) with
| Cpy (copy) -> begin
copy
end))


type 'a rvector =
'a LowStar_Vector.vector










let alloc_empty = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) -> LowStar_Vector.Vec ((FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))), (LowStar_Monotonic_Buffer.mnull ())))


let rec alloc_ = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( rv  :  'a rvector ) ( cidx  :  LowStar_Vector.uint32_t ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in (match ((Prims.op_Equality cidx (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))) with
| true -> begin
()
end
| uu___ -> begin
((FStar_HyperStack_ST.new_region ());
(

let v = (LowStar_Regional.__proj__Rgl__item__r_alloc rg (LowStar_Regional.__proj__Rgl__item__state rg) ())
in (

let hh1 = (FStar_HyperStack_ST.get ())
in ((LowStar_Vector.assign rv (FStar_UInt32.sub cidx (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))) v);
(

let hh2 = (FStar_HyperStack_ST.get ())
in ((alloc_ rg rv (FStar_UInt32.sub cidx (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))));
(

let hh3 = (FStar_HyperStack_ST.get ())
in ());
));
)));
)
end)))


let alloc_rid = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( len  :  LowStar_Vector.uint32_t ) ( rid  :  unit ) -> (

let vec = (LowStar_Vector.alloc_rid len (LowStar_Regional.__proj__Rgl__item__dummy rg) ())
in ((alloc_ rg vec len);
vec;
)))


let alloc_reserve = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( len  :  LowStar_Vector.uint32_t ) ( rid  :  unit ) -> (LowStar_Vector.alloc_reserve len (LowStar_Regional.__proj__Rgl__item__dummy rg) ()))


let alloc = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( len  :  LowStar_Vector.uint32_t ) -> ((FStar_HyperStack_ST.new_region ());
(alloc_rid rg len ());
))


let insert = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( rv  :  'a rvector ) ( v  :  'a ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in (

let irv = (LowStar_Vector.insert rv v)
in (

let hh1 = (FStar_HyperStack_ST.get ())
in irv))))


let insert_copy = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( cp  :  ('rst, 'a, obj) copyable ) ( rv  :  'a rvector ) ( v  :  'a ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in ((FStar_HyperStack_ST.new_region ());
(

let nv = (LowStar_Regional.__proj__Rgl__item__r_alloc rg (LowStar_Regional.__proj__Rgl__item__state rg) ())
in (

let hh1 = (FStar_HyperStack_ST.get ())
in (((match (cp) with
| Cpy (copy) -> begin
copy
end) (LowStar_Regional.__proj__Rgl__item__state rg) v nv);
(

let hh2 = (FStar_HyperStack_ST.get ())
in (insert rg rv nv));
)));
)))


let assign = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( rv  :  'a rvector ) ( i  :  LowStar_Vector.uint32_t ) ( v  :  'a ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in ((LowStar_Vector.assign rv i v);
(

let hh1 = (FStar_HyperStack_ST.get ())
in ());
)))


let assign_copy = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( cp  :  ('rst, 'a, obj) copyable ) ( rv  :  'a rvector ) ( i  :  LowStar_Vector.uint32_t ) ( v  :  'a ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in ((

let uu___1 = (LowStar_Vector.index rv i)
in ((match (cp) with
| Cpy (copy) -> begin
copy
end) (LowStar_Regional.__proj__Rgl__item__state rg) v uu___1));
(

let hh1 = (FStar_HyperStack_ST.get ())
in ());
)))


let rec free_elems = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( rv  :  'a rvector ) ( idx  :  LowStar_Vector.uint32_t ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in ((

let uu___1 = (LowStar_Vector.index rv idx)
in (LowStar_Regional.__proj__Rgl__item__r_free rg (LowStar_Regional.__proj__Rgl__item__state rg) uu___1));
(

let hh1 = (FStar_HyperStack_ST.get ())
in (match ((Prims.op_disEquality idx (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))) with
| true -> begin
(free_elems rg rv (FStar_UInt32.sub idx (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))))
end
| uu___1 -> begin
()
end));
)))


let flush = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( rv  :  'a rvector ) ( i  :  LowStar_Vector.uint32_t ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in ((match ((Prims.op_Equality i (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))) with
| true -> begin
()
end
| uu___1 -> begin
(free_elems rg rv (FStar_UInt32.sub i (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))))
end);
(

let hh1 = (FStar_HyperStack_ST.get ())
in (

let frv = (LowStar_Vector.flush rv (LowStar_Regional.__proj__Rgl__item__dummy rg) i)
in (

let hh2 = (FStar_HyperStack_ST.get ())
in frv)));
)))


let rec free_elems_from = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( rv  :  'a rvector ) ( idx  :  LowStar_Vector.uint32_t ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in ((

let uu___1 = (LowStar_Vector.index rv idx)
in (LowStar_Regional.__proj__Rgl__item__r_free rg (LowStar_Regional.__proj__Rgl__item__state rg) uu___1));
(

let hh1 = (FStar_HyperStack_ST.get ())
in (match ((FStar_UInt32.lt (FStar_UInt32.add idx (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))) (match (rv) with
| LowStar_Vector.Vec (sz, cap, vs) -> begin
sz
end))) with
| true -> begin
(free_elems_from rg rv (FStar_UInt32.add idx (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))))
end
| uu___1 -> begin
()
end));
)))


let shrink = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( rv  :  'a rvector ) ( new_size  :  LowStar_Vector.uint32_t ) -> (

let size = (match (rv) with
| LowStar_Vector.Vec (sz, cap, vs) -> begin
sz
end)
in (

let hh0 = (FStar_HyperStack_ST.get ())
in (match ((FStar_UInt32.gte new_size size)) with
| true -> begin
rv
end
| uu___ -> begin
((free_elems_from rg rv new_size);
(

let hh1 = (FStar_HyperStack_ST.get ())
in (

let frv = (LowStar_Vector.shrink rv new_size)
in (

let hh2 = (FStar_HyperStack_ST.get ())
in frv)));
)
end))))


let free = (fun ( rg  :  ('rst, 'a) LowStar_Regional.regional ) ( rv  :  'a rvector ) -> (

let hh0 = (FStar_HyperStack_ST.get ())
in ((match ((Prims.op_Equality (match (rv) with
| LowStar_Vector.Vec (sz, cap, vs) -> begin
sz
end) (FStar_UInt32.uint_to_t ((Prims.parse_int "0"))))) with
| true -> begin
()
end
| uu___1 -> begin
(free_elems rg rv (FStar_UInt32.sub (match (rv) with
| LowStar_Vector.Vec (sz, cap, vs) -> begin
sz
end) (FStar_UInt32.uint_to_t ((Prims.parse_int "1")))))
end);
(

let hh1 = (FStar_HyperStack_ST.get ())
in (LowStar_Vector.free rv));
)))




