#light "off"
module GC
type color =
| Unalloc
| White
| Gray
| Black


let uu___is_Unalloc : color  ->  Prims.bool = (fun ( projectee  :  color ) -> (match (projectee) with
| Unalloc -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_White : color  ->  Prims.bool = (fun ( projectee  :  color ) -> (match (projectee) with
| White -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Gray : color  ->  Prims.bool = (fun ( projectee  :  color ) -> (match (projectee) with
| Gray -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_Black : color  ->  Prims.bool = (fun ( projectee  :  color ) -> (match (projectee) with
| Black -> begin
true
end
| uu___ -> begin
false
end))


let mem_lo : Prims.int = (Prims.unsafe_coerce (fun ( uu___  :  Prims.int ) -> (failwith "Not yet implemented: GC.mem_lo")))


let mem_hi : Prims.int = (Prims.unsafe_coerce (fun ( uu___  :  Prims.int ) -> (failwith "Not yet implemented: GC.mem_hi")))


let is_mem_addr : Prims.int  ->  Prims.bool = (fun ( i  :  Prims.int ) -> ((mem_lo <= i) && (i < mem_hi)))

type field =
| F1
| F2


let uu___is_F1 : field  ->  Prims.bool = (fun ( projectee  :  field ) -> (match (projectee) with
| F1 -> begin
true
end
| uu___ -> begin
false
end))


let uu___is_F2 : field  ->  Prims.bool = (fun ( projectee  :  field ) -> (match (projectee) with
| F2 -> begin
true
end
| uu___ -> begin
false
end))


type abs_node =
unit


let no_abs : abs_node = (Prims.unsafe_coerce (fun ( uu___  :  abs_node ) -> (failwith "Not yet implemented: GC.no_abs")))


let valid : abs_node  ->  Prims.bool = (fun ( a  :  abs_node ) -> (Prims.op_disEquality a no_abs))


type valid_node =
abs_node


type mem_addr =
Prims.int


type color_map =
mem_addr  ->  color


type abs_map =
mem_addr  ->  abs_node


type field_map =
(mem_addr * field)  ->  mem_addr


type abs_field_map =
(abs_node * field)  ->  abs_node


type trigger =
unit


type to_abs_inj =
unit

type gc_state =
{to_abs : abs_map; color : color_map; abs_fields : abs_field_map; fields : field_map}


let __proj__Mkgc_state__item__to_abs : gc_state  ->  abs_map = (fun ( projectee  :  gc_state ) -> (match (projectee) with
| {to_abs = to_abs; color = color1; abs_fields = abs_fields; fields = fields} -> begin
to_abs
end))


let __proj__Mkgc_state__item__color : gc_state  ->  color_map = (fun ( projectee  :  gc_state ) -> (match (projectee) with
| {to_abs = to_abs; color = color1; abs_fields = abs_fields; fields = fields} -> begin
color1
end))


let __proj__Mkgc_state__item__abs_fields : gc_state  ->  abs_field_map = (fun ( projectee  :  gc_state ) -> (match (projectee) with
| {to_abs = to_abs; color = color1; abs_fields = abs_fields; fields = fields} -> begin
abs_fields
end))


let __proj__Mkgc_state__item__fields : gc_state  ->  field_map = (fun ( projectee  :  gc_state ) -> (match (projectee) with
| {to_abs = to_abs; color = color1; abs_fields = abs_fields; fields = fields} -> begin
fields
end))


type ptr_lifts =
unit


type ptr_lifts_to =
unit


type obj_inv =
unit


type inv =
unit


type gc_inv =
unit


type mutator_inv =
unit


type gc_post =
unit


let get : unit  ->  gc_state = (fun ( uu___  :  unit ) -> (failwith "Not yet implemented: GC.get"))


let set : gc_state  ->  unit = (fun ( g  :  gc_state ) -> (failwith "Not yet implemented: GC.set"))


type init_invariant =
unit


let upd_map = (fun ( f  :  'a  ->  'b ) ( i  :  'a ) ( v  :  'b ) ( j  :  'a ) -> (match ((Prims.op_Equality i j)) with
| true -> begin
v
end
| uu___ -> begin
(f j)
end))


let upd_map2 = (fun ( m  :  'a  ->  'b  ->  'c ) ( i  :  'a ) ( f  :  'b ) ( v  :  'c ) ( j  :  'a ) ( g  :  'b ) -> (match ((Prims.op_Equality ((i), (f)) ((j), (g)))) with
| true -> begin
v
end
| uu___ -> begin
(m j g)
end))


let initialize : unit  ->  unit = (fun ( uu___  :  unit ) -> (

let rec aux_init : mem_addr  ->  unit = (fun ( ptr  :  mem_addr ) -> (

let gc = (get ())
in (

let gc' = {to_abs = (upd_map gc.to_abs ptr no_abs); color = (upd_map gc.color ptr Unalloc); abs_fields = gc.abs_fields; fields = gc.fields}
in ((set gc');
(match (((ptr + (Prims.parse_int "1")) < mem_hi)) with
| true -> begin
(aux_init (ptr + (Prims.parse_int "1")))
end
| uu___2 -> begin
()
end);
))))
in (aux_init mem_lo)))


let read_field : mem_addr  ->  field  ->  mem_addr = (fun ( ptr  :  mem_addr ) ( f  :  field ) -> (

let gc = (get ())
in (gc.fields ((ptr), (f)))))


let write_field : mem_addr  ->  field  ->  mem_addr  ->  unit = (fun ( ptr  :  mem_addr ) ( f  :  field ) ( v  :  mem_addr ) -> (

let gc = (get ())
in (

let gc' = {to_abs = gc.to_abs; color = gc.color; abs_fields = (upd_map gc.abs_fields (((gc.to_abs ptr)), (f)) (gc.to_abs v)); fields = (upd_map gc.fields ((ptr), (f)) v)}
in (set gc'))))


let rec mark : mem_addr  ->  unit = (fun ( ptr  :  mem_addr ) -> (

let st = (get ())
in (match ((Prims.op_Equality (st.color ptr) White)) with
| true -> begin
(

let st' = {to_abs = st.to_abs; color = (upd_map st.color ptr Gray); abs_fields = st.abs_fields; fields = st.fields}
in ((set st');
(mark (st'.fields ((ptr), (F1))));
(mark (st'.fields ((ptr), (F2))));
(

let st'' = (get ())
in (set {to_abs = st''.to_abs; color = (upd_map st''.color ptr Black); abs_fields = st''.abs_fields; fields = st''.fields}));
))
end
| uu___ -> begin
()
end)))


type sweep_aux_inv =
unit


let sweep : unit  ->  unit = (fun ( uu___  :  unit ) -> (

let old = (get ())
in (

let rec sweep_aux : mem_addr  ->  unit = (fun ( ptr  :  mem_addr ) -> (

let st = (get ())
in ((match ((Prims.op_Equality (st.color ptr) White)) with
| true -> begin
(

let st' = {to_abs = (upd_map st.to_abs ptr no_abs); color = (upd_map st.color ptr Unalloc); abs_fields = st.abs_fields; fields = st.fields}
in (set st'))
end
| uu___2 -> begin
(match ((Prims.op_Equality (st.color ptr) Black)) with
| true -> begin
(

let st' = {to_abs = st.to_abs; color = (upd_map st.color ptr White); abs_fields = st.abs_fields; fields = st.fields}
in (set st'))
end
| uu___3 -> begin
()
end)
end);
(match (((ptr + (Prims.parse_int "1")) < mem_hi)) with
| true -> begin
(sweep_aux (ptr + (Prims.parse_int "1")))
end
| uu___2 -> begin
()
end);
)))
in (sweep_aux mem_lo))))


let gc : mem_addr  ->  unit = (fun ( root  :  mem_addr ) -> ((match ((Prims.op_disEquality root (Prims.parse_int "0"))) with
| true -> begin
(mark root)
end
| uu___1 -> begin
()
end);
(sweep ());
))


type try_alloc_invariant =
unit


let rec alloc : mem_addr  ->  abs_node  ->  mem_addr = (fun ( root  :  mem_addr ) ( abs  :  abs_node ) -> (

let rec try_alloc_at_ptr : mem_addr  ->  abs_node  ->  Prims.int = (fun ( ptr  :  mem_addr ) ( abs1  :  abs_node ) -> (

let gc1 = (get ())
in (match ((Prims.op_Equality (gc1.color ptr) Unalloc)) with
| true -> begin
(

let fields = (upd_map gc1.fields ((ptr), (F1)) ptr)
in (

let fields1 = (upd_map fields ((ptr), (F2)) ptr)
in (

let gc' = {to_abs = (upd_map gc1.to_abs ptr abs1); color = (upd_map gc1.color ptr White); abs_fields = gc1.abs_fields; fields = fields1}
in ((set gc');
ptr;
))))
end
| uu___ -> begin
(match (((ptr + (Prims.parse_int "1")) < mem_hi)) with
| true -> begin
(try_alloc_at_ptr (ptr + (Prims.parse_int "1")) abs1)
end
| uu___1 -> begin
mem_hi
end)
end)))
in (

let ptr = (try_alloc_at_ptr mem_lo abs)
in (match ((ptr < mem_hi)) with
| true -> begin
ptr
end
| uu___ -> begin
((gc root);
(alloc root abs);
)
end))))




