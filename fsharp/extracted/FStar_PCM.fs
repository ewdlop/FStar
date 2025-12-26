#light "off"
module FStar_PCM

type symrel =
unit

type 'a pcm' =
{composable : unit; op : 'a  ->  'a  ->  'a; one : 'a}


let __proj__Mkpcm'__item__op = (fun ( projectee  :  'a pcm' ) -> (match (projectee) with
| {composable = composable; op = op; one = one} -> begin
op
end))


let __proj__Mkpcm'__item__one = (fun ( projectee  :  'a pcm' ) -> (match (projectee) with
| {composable = composable; op = op; one = one} -> begin
one
end))


type lem_commutative =
unit


type lem_assoc_l =
unit


type lem_assoc_r =
unit


type lem_is_unit =
unit

type 'a pcm =
{p : 'a pcm'; comm : unit; assoc : unit; assoc_r : unit; is_unit : unit; refine : unit}


let __proj__Mkpcm__item__p = (fun ( projectee  :  'a pcm ) -> (match (projectee) with
| {p = p; comm = comm; assoc = assoc; assoc_r = assoc_r; is_unit = is_unit; refine = refine} -> begin
p
end))














type composable =
obj


let op = (fun ( p  :  'a pcm ) ( x  :  'a ) ( y  :  'a ) -> (p.p.op x y))


type compatible =
unit


type joinable =
unit


type frame_compatible =
unit


type 'a frame_preserving_upd =
'a  ->  'a


type frame_preserving =
unit


let frame_preserving_val_to_fp_upd = (fun ( p  :  'a pcm ) ( x  :  unit ) ( v  :  'a ) ( uu___  :  'a ) -> v)


type exclusive =
unit


let no_op_is_frame_preserving = (fun ( p  :  'a pcm ) ( x  :  'a ) ( v  :  'a ) -> v)


let compose_frame_preserving_updates = (fun ( p  :  'a pcm ) ( x  :  'a ) ( y  :  'a ) ( z  :  'a ) ( f  :  'a frame_preserving_upd ) ( g  :  'a frame_preserving_upd ) ( v  :  'a ) -> (g (f v)))


let frame_preserving_subframe = (fun ( p  :  'a pcm ) ( x  :  'a ) ( y  :  'a ) ( subframe  :  'a ) ( f  :  'a frame_preserving_upd ) ( v  :  'a ) -> (

let w = (f v)
in w))




