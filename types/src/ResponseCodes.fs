namespace SharedTypes

module ResponseCodes =


    type StatusCode =
        { StatusCode: int
          StatusMessage: string }

    type E6ResponseCode =
        | Ok of StatusCode
        | No_Content of StatusCode
        | Forbidden of StatusCode
        | Not_Found of StatusCode
        | Precondition_Failed of StatusCode
        | Invalid_Record of StatusCode
        | User_Throttled of StatusCode
        | Locked of StatusCode
        | Alread_Exists of StatusCode
        | Invalid_Paramerets of StatusCode
        | Internal_Server_Error of StatusCode
        | Bad_Gateway of StatusCode
        | Service_Unavailable of StatusCode
        | Unknown_Error of StatusCode
        | Origin_Connection_Timeout_Cloudflare of StatusCode
        | Origin_Connection_Timeout_E621 of StatusCode
        | SSL_Handshake_Failed of StatusCode
