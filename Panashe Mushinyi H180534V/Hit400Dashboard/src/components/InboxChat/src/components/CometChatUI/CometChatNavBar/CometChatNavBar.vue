<template class="">
    <div class="light cometchat__unified__navbar">
        <div :style="styles.footer" class="sidebar__footer">
            <div :style="styles.navbar" class="footer__navbar">
                <div
                    class="TabItem"
                    :style="styles.item"
                    @click="changeTab('conversations')"
                >
                    <span
                        :class="isChatsTabActive ? 'greenTitle' : 'greyTitle'"
                        class="charts"
                    >
                        Chats
                    </span>
                    <div v-if="isChatsTabActive" class="TabIndicator"></div>
                </div>
                <!-- <div :style="styles.item" @click="changeTab('contacts')">
          <span :style="styles.contactIcon"></span>
        </div> -->
                <div
                    class="TabItem"
                    :style="styles.item"
                    @click="changeTab('groups')"
                >
                    <span
                        :class="isGroupsTabActive ? 'greenTitle' : 'greyTitle'"
                        class="groups"
                        >Groups</span
                    >
                    <div v-if="isGroupsTabActive" class="TabIndicator"></div>
                </div>
                <!--         <div :style="styles.item" @click="changeTab('info')">
          <span :style="styles.moreIcon"></span>
        </div> -->
            </div>
        </div>
        <template v-if="tab === 'contacts'">
            <comet-chat-user-list
                :item="item"
                :type="type"
                :theme="theme"
                :enable-close-menu="enableCloseMenu"
                @action="actionHandler"
            />
        </template>
        <template v-else-if="tab === 'conversations'">
            <comet-chat-conversation-list
                :item="item"
                :type="type"
                :theme="theme"
                :last-message="lastMessage"
                :group-to-leave="groupToLeave"
                :group-to-delete="groupToDelete"
                :group-to-update="groupToUpdate"
                :enable-close-menu="enableCloseMenu"
                :message-to-mark-read="messageToMarkRead"
                @action="actionHandler"
            />
        </template>
        <template v-else-if="tab === 'groups'">
            <comet-chat-group-list
                :item="item"
                :type="type"
                :theme="theme"
                :group-to-leave="groupToLeave"
                :group-to-delete="groupToDelete"
                :group-to-update="groupToUpdate"
                :enable-close-menu="enableCloseMenu"
                @action="actionHandler"
            />
            <comet-chat-conversation-list-jobs
                :item="item"
                :type="type"
                :theme="theme"
                :last-message="lastMessage"
                :group-to-leave="groupToLeave"
                :group-to-delete="groupToDelete"
                :group-to-update="groupToUpdate"
                :enable-close-menu="enableCloseMenu"
                :message-to-mark-read="messageToMarkRead"
                @action="actionHandler"
            />
        </template>
        <template v-else-if="tab === 'info'">
            <comet-chat-user-profile :theme="theme" @action="actionHandler" />
        </template>
    </div>
</template>
<script>
/* eslint-disable */
import {
    DEFAULT_OBJECT_PROP,
    DEFAULT_STRING_PROP,
    DEFAULT_BOOLEAN_PROP,
} from '../../../resources/constants'

import { cometChatCommon } from '../../../mixins/'

import {
    CometChatConversationList,
    CometChatConversationListJobs,
} from '../../Chats/'
import { CometChatUserProfile } from '../../UserProfile/'
import { CometChatGroupList } from '../../Groups'
import { CometChatUserList } from '../../Users'

import contactGreyIcon from './resources/contacts-grey.png'
import contactBlueIcon from './resources/contacts-blue.png'
import moreGreyIcon from './resources/userInfo-grey.png'
import moreBlueIcon from './resources/userInfo-blue.png'
import groupBlueIcon from './resources/groups-blue.png'
import groupGreyIcon from './resources/groups-grey.png'
import chatGreyIcon from './resources/chats-grey.png'
import chatBlueIcon from './resources/chats-blue.png'

import * as style from './style'

/**
 * Navigation bar for switching tabs in CometChatUI.
 *
 * @displayName CometChatNavBar
 */
export default {
    name: 'CometChatNavBar',
    mixins: [cometChatCommon],
    components: {
        CometChatConversationList,
        CometChatConversationListJobs,
        CometChatUserProfile,
        CometChatGroupList,
        CometChatUserList,
    },
    props: {
        /**
         * Current active tab.
         * @values conversations, contacts, groups, info
         */
        tab: { ...DEFAULT_STRING_PROP },
        /**
         * The selected chat item object.
         */
        item: { ...DEFAULT_OBJECT_PROP },
        /**
         * Type of chat item.
         */
        type: { ...DEFAULT_STRING_PROP },
        /**
         * Theme of the UI.
         */
        theme: { ...DEFAULT_OBJECT_PROP },
        /**
         * Last message in message list.
         */
        lastMessage: { ...DEFAULT_OBJECT_PROP },
        /**
         * The group selected to leave.
         */
        groupToLeave: { ...DEFAULT_OBJECT_PROP },
        /**
         * The group selected to update.
         */
        groupToUpdate: { ...DEFAULT_OBJECT_PROP },
        /**
         * The group selected to delete.
         */
        groupToDelete: { ...DEFAULT_OBJECT_PROP },
        /**
         * Shows/hides the close menu button.
         */
        enableCloseMenu: { ...DEFAULT_BOOLEAN_PROP },
        /**
         * Message marked to read.
         */
        messageToMarkRead: { ...DEFAULT_OBJECT_PROP },
    },
    computed: {
        /**
         * Computed styles for the component.
         */
        User: function () {
            return this.$store.state.Profile.user
        },
        styles() {
            return {
                item: style.itemStyle(),
                footer: style.footerStyle(),
                navbar: style.navbarStyle(),
            }
        },
        /**
         * Whether chats tab is active.
         */
        isChatsTabActive() {
            return this.tab === 'conversations'
        },
        /**
         * Whether users tab is active.
         */
        isContactsTabActive() {
            return this.tab === 'contacts'
        },
        /**
         * Whether groups tab is active.
         */
        isGroupsTabActive() {
            return this.tab === 'groups'
        },
        /**
         * Whether info tab is active.
         */
        isMoreTabActive() {
            return this.tab === 'info'
        },
    },
    methods: {
        /**
         * Emits change tab event
         */
        changeTab(tab) {
            this.emitAction('tabChanged', { tab })
        },
        /**
         * Handles emitted action events
         */
        actionHandler({ action, ...rest }) {
            this.emitAction(action, { ...rest })
        },
    },
}
</script>
<style scoped>
.cometchat__unified__navbar {
    height: 80vh;
    width: 280px;
    border-radius: 10px 0px 0px 10px;
}
.greenTitle {
    color: #0d7a3e;
}
.greyTitle {
    color: #979797;
}
.light.cometchat__unified__navbar {
    background-color: #fff;
}
.charts {
    font-family: Poppins;
    font-size: 16px;
    font-style: normal;
    font-weight: 700;
    line-height: 24px;
    letter-spacing: 0em;
    text-align: left;
}
.groups {
    font-family: Poppins;
    font-size: 16px;
    font-style: normal;
    font-weight: 700;
    line-height: 24px;
    letter-spacing: 0em;
    text-align: left;
}

.dark.cometchat__unified__navbar {
    background-color: #1a1a1a;
}

.cometchat__unified__navbar .chats__wrapper,
.cometchat__unified__navbar .groups__wrapper,
.cometchat__unified__navbar .contacts__wrapper {
    height: calc(100% - 50px) !important;
}
.sidebar__footer {
    justify-content: space-between;
    width: 100%;
}
.footer__navbar {
    display: flex;
    flex-direction: column;
    justify-content: space-between;
    border-bottom: 1px solid #e6e6e6;
    height: 78px;
}
.TabItem {
    display: flex !important;
    flex-direction: column;
    justify-content: space-between;
    height: 100%;
    padding: 36px 0px 0px 0px !important;
}
.TabIndicator {
    background: #0d7a3e;
    height: 5px;
    border-radius: 10px 10px 0px 0px;
}

@media (min-width: 320px) and (max-width: 767px) {
    .cometchat__unified__navbar {
        width: 100% !important;
    }
}
</style>
