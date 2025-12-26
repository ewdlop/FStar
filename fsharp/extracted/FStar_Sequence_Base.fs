#light "off"
module FStar_Sequence_Base

type 'ty seq =
'ty Prims.list


let length = (fun ( uu___  :  'ty seq ) -> ((Prims.unsafe_coerce FStar_List_Tot_Base.length) uu___))


let empty = (fun ( uu___  :  unit ) -> ((fun ( uu___  :  unit ) -> (Prims.unsafe_coerce [])) uu___))


let singleton = (fun ( uu___  :  'ty ) -> ((fun ( v  :  'ty ) -> (Prims.unsafe_coerce (v)::[])) uu___))


let index = (fun ( s  :  'ty seq ) ( i  :  Prims.nat ) -> (FStar_List_Tot_Base.index (Prims.unsafe_coerce s) i))


let op_Dollar_At = (fun ( uu___  :  unit ) -> index)


let build = (fun ( uu___1  :  'ty seq ) ( uu___  :  'ty ) -> ((fun ( s  :  'ty seq ) ( v  :  'ty ) -> (Prims.unsafe_coerce (FStar_List_Tot_Base.append (Prims.unsafe_coerce s) ((v)::[])))) uu___1 uu___))


let op_Dollar_Colon_Colon = (fun ( uu___  :  unit ) -> build)


let append = (fun ( uu___1  :  'ty seq ) ( uu___  :  'ty seq ) -> ((Prims.unsafe_coerce FStar_List_Tot_Base.append) uu___1 uu___))


let op_Dollar_Plus = (fun ( uu___  :  unit ) -> append)


let update = (fun ( s  :  'ty seq ) ( i  :  Prims.nat ) ( v  :  'ty ) -> (

let uu___ = (FStar_List_Tot_Base.split3 (Prims.unsafe_coerce s) i)
in (match (uu___) with
| (s1, uu___1, s2) -> begin
(append (Prims.unsafe_coerce s1) (append (Prims.unsafe_coerce (v)::[]) (Prims.unsafe_coerce s2)))
end)))



let take = (fun ( uu___1  :  'ty seq ) ( uu___  :  Prims.nat ) -> ((fun ( s  :  'ty seq ) ( howMany  :  Prims.nat ) -> (let uu___ = (FStar_List_Tot_Base.splitAt howMany (Prims.unsafe_coerce s))
in (match (uu___) with
| (result, uu___1) -> begin
(Prims.unsafe_coerce result)
end))) uu___1 uu___))


let drop = (fun ( uu___1  :  'ty seq ) ( uu___  :  Prims.nat ) -> ((fun ( s  :  'ty seq ) ( howMany  :  Prims.nat ) -> (let uu___ = (FStar_List_Tot_Base.splitAt howMany (Prims.unsafe_coerce s))
in (match (uu___) with
| (uu___1, result) -> begin
(Prims.unsafe_coerce result)
end))) uu___1 uu___))



type op_Dollar_Equals_Equals =
unit



type op_Dollar_Less_Equals =
unit


let rank = (fun ( v  :  'ty ) -> v)


type length_of_empty_is_zero_fact =
unit


type length_zero_implies_empty_fact =
unit


type singleton_length_one_fact =
unit


type build_increments_length_fact =
unit


type index_into_build_fact =
unit


type append_sums_lengths_fact =
unit


type index_into_singleton_fact =
unit


type index_after_append_fact =
unit


type update_maintains_length_fact =
unit


type update_then_index_fact =
unit


type contains_iff_exists_index_fact =
unit


type empty_doesnt_contain_anything_fact =
unit


type build_contains_equiv_fact =
unit


type take_contains_equiv_exists_fact =
unit


type drop_contains_equiv_exists_fact =
unit


type equal_def_fact =
unit


type extensionality_fact =
unit


type is_prefix_def_fact =
unit


type take_length_fact =
unit


type index_into_take_fact =
unit


type drop_length_fact =
unit


type index_into_drop_fact =
unit


type drop_index_offset_fact =
unit


type append_then_take_or_drop_fact =
unit


type take_commutes_with_in_range_update_fact =
unit


type take_ignores_out_of_range_update_fact =
unit


type drop_commutes_with_in_range_update_fact =
unit


type drop_ignores_out_of_range_update_fact =
unit


type drop_commutes_with_build_fact =
unit


type rank_def_fact =
unit


type element_ranks_less_fact =
unit


type drop_ranks_less_fact =
unit


type take_ranks_less_fact =
unit


type append_take_drop_ranks_less_fact =
unit


type drop_zero_fact =
unit


type take_zero_fact =
unit


type drop_then_drop_fact =
unit


type all_seq_facts =
unit




