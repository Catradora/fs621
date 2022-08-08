namespace SharedTypes

module Posts =
    type Rating =
        | Safe
        | Questionable
        | Explicit

    module Create =
        type CreateRequestParameters =
            { tag_string: string
              file: byte []
              rating: Rating
              direct_url: Option<string>
              source: seq<string>
              description: Option<string>
              parent_id: Option<int>
              referer_url: Option<string>
              md5_confirmation: Option<string>
              as_pending: Option<bool> }

        type private CreateSuccessResponse =
            { success: bool
              location: string
              post_id: int }

        type private CreateFailureResponse =
            { success: bool
              reason: string
              location: string
              post_id: int }

        type CreateResponseFields =
            | CreateSuccessResponse
            | CreateFailureResponse

    module Update =
        type UpdateRequestParameters =
            { tag_string_diff: Option<seq<string>>
              source_diff: Option<seq<string>>
              parent_id: Option<int>
              old_parent_id: Option<int>
              description: Option<string>
              old_description: Option<string>
              rating: Option<Rating>
              old_rating: Option<Rating>
              is_rating_locked: Option<bool>
              is_note_locked: Option<bool>
              edit_reason: Option<string>
              has_embedded_notes: Option<bool> }


    module List =
        open System

        type Page =
            | Page of int
            | Before of int
            | After of int

        type File =
            { width: int
              height: int
              ext: string
              size: int
              md5: string
              url: string }

        type Preview =
            { width: int
              height: int
              url: string }

        type Sample =
            { has: bool
              width: int
              height: int
              url: string
              alternates: string }

        type Score = { up: int; down: int; total: int }

        type ListRequestParameters =
            { limit: Option<int>
              tags: Option<seq<string>>
              page: Option<Page> }

        type ListResponseFields =
            { id: int
              created_at: DateTime
              updated_at: DateTime
              file: seq<File>
              preview: seq<Preview>
              sample: seq<Sample>
              score: Score
              tags: General.Tags
              locked_tags: seq<General.Tag>
              change_seq: int
              flags: General.Flags
              rating: Rating
              fav_count: int
              sources: seq<string>
              pools: seq<int>
              relationships: General.Relationship
              approver_id: Option<int>
              uploader_id: int
              description: string
              comment_count: int
              is_favorited: Option<bool>
              has_notes: bool
              duration: Option<int> }
