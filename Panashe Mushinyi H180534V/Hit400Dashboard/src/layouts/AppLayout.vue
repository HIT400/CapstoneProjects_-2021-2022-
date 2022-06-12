<template>
    <component :is="layout">
        <slot />
    </component>
</template>

<script>
import AppLayoutDefault from './AppLayoutDefault.vue'
import { markRaw, watch, ref } from 'vue'
import { useRoute } from 'vue-router'
export default {
    name: 'AppLayout',
    setup() {
        const layout = ref(AppLayoutDefault)
        const route = useRoute()

        watch(
            () => route.meta,
            async (meta) => {
                try {
                    const component = await import(
                        /* @vite-ignore */
                        `./${meta.layout}.vue`
                    )
                    layout.value = component?.default || AppLayoutDefault
                } catch (e) {
                    layout.value = AppLayoutDefault
                }
            },
            { immediate: true }
        )
        return { layout }
    },
}
</script>
