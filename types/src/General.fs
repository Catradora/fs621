namespace SharedTypes

module General =
    type Login = string
    type API_Key = string

    type LoginInfo = { Login: Login; API_Key: API_Key }

    type Tag = string

    type Tags =
        { General: seq<Tag>
          Species: seq<Tag>
          Character: seq<Tag>
          Artist: seq<Tag>
          Invalid: seq<Tag>
          Lore: seq<Tag>
          Meta: seq<Tag> }

    type Flag = bool

    type Flags =
        { Pending: Flag
          Flagged: Flag
          Note_Locked: Flag
          Status_Locked: Flag
          Rating_Locked: Flag
          Comment_Disabled: Flag
          Deleted: Flag }

    type Relationship =
        { parent_id: Option<int>
          has_children: bool
          has_active_children: bool
          children: seq<int> }
