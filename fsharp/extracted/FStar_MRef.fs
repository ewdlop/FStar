#light "off"
module FStar_MRef

type stable =
unit


type p_pred =
unit



let witness_token = (fun ( m  :  'uuuuu FStar_ST.mref ) ( p  :  unit ) -> ((FStar_ST.gst_recall ());
(FStar_ST.gst_witness ());
))


let recall_token = (fun ( m  :  'uuuuu FStar_ST.mref ) ( p  :  unit ) -> (FStar_ST.gst_recall ()))


type spred =
unit


let recall = (fun ( uu___  :  unit ) -> (FStar_ST.gst_recall ()))


let witness = (fun ( uu___  :  unit ) -> (FStar_ST.gst_witness ()))




