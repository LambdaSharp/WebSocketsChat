/*
 * LambdaSharp (λ#)
 * Copyright (C) 2018-2020
 * lambdasharp.net
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace Demo.WebSocketsChat.Common {

    public class Notification {

        //--- Properties ---
        public string Action { get; set; }
    }

    public class UserMessageNotification : Notification {

        //--- Constructors ---
        public UserMessageNotification() => Action = "message";

        //--- Properties ---
        public string UserId { get; set; }
        public string ChannelId { get; set; }
        public string Text { get; set; }
    }

    public class UserNameNotification : Notification  {

        //--- Constructors ---
        public UserNameNotification() => Action = "username";

        //--- Properties ---
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string OldUserName { get; set; }
    }
}