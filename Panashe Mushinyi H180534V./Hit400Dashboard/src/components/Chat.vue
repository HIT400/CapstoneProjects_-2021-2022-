<template>
    <div class="main_x">
        <CometChatUI />
    </div>
</template>

<script>
/* eslint-disable */
import { CometChatUI } from './InboxChat/src'
import { CometChat } from '@cometchat-pro/chat'
export default {
    name: 'App',
    components: {
        CometChatUI,
    },
    computed: {},
    methods: {
        /*  send() {
      const id = "Exercitation quidem";
      let receiverID = id.toLowerCase().replace(/\s+/g, "");
      console.log(receiverID);
      let messageText = "http://localhost:8080/client/inbox";
      let receiverType = CometChat.RECEIVER_TYPE.USER;
      let textMessage = new CometChat.TextMessage(
        receiverID,
        messageText,
        receiverType
      );

      CometChat.sendMessage(textMessage).then(
        (message) => {
          console.log("Message sent successfully:", message);
        },
        (error) => {
          console.log("Message sending failed with error:", error);
        }
      );
    }, */
    },
}
</script>

<style scoped>
h1 {
    color: #fff;
}

.main_x {
    max-width: 70vw;
    min-height: 80vh;
    margin: auto;
}
.row.h1 {
    font-size: 30px;
    font-weight: 500;
    line-height: 45px;
    margin-bottom: 40px;
}

.chat-page {
    max-height: 50vh;
    height: 50vh;
}

.chat-container {
    max-height: 50vh;
    height: 50vh;
}

.chat-main {
    max-height: 50vh;
    height: 50vh;
}
</style>
