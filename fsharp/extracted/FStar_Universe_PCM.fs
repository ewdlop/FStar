#light "off"
module FStar_Universe_PCM

let raise = (fun ( p  :  'a FStar_PCM.pcm ) -> {FStar_PCM.p = {FStar_PCM.composable = (); FStar_PCM.op = (fun ( x  :  'a FStar_Universe.raise_t ) ( y  :  'a FStar_Universe.raise_t ) -> (FStar_Universe.raise_val (p.p.op (FStar_Universe.downgrade_val x) (FStar_Universe.downgrade_val y)))); FStar_PCM.one = (FStar_Universe.raise_val p.p.one)}; FStar_PCM.comm = (); FStar_PCM.assoc = (); FStar_PCM.assoc_r = (); FStar_PCM.is_unit = (); FStar_PCM.refine = ()})


let raise_frame_preserving_upd = (fun ( p  :  'a FStar_PCM.pcm ) ( x  :  'a ) ( y  :  'a ) ( f  :  'a FStar_PCM.frame_preserving_upd ) ( v  :  'a FStar_Universe.raise_t ) -> (

let u = (f (FStar_Universe.downgrade_val v))
in (

let v_new = (FStar_Universe.raise_val u)
in v_new)))




