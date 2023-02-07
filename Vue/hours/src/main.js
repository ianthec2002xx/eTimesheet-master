// The Vue build version to load with the `import` command
// (runtime-only or standalone) has been set in webpack.base.conf with an alias.
import Vue from 'vue'
import App from './App'

import BootstrapVue from 'bootstrap-vue'
import 'bootstrap/dist/css/bootstrap.css'
import 'bootstrap-vue/dist/bootstrap-vue.css'
import {  BootstrapVueIcons }  from 'bootstrap-vue'
import { BSidebar } from 'bootstrap-vue'
import { BContainer } from 'bootstrap-vue'
import { LayoutPlugin } from 'bootstrap-vue'
import { BRow } from 'bootstrap-vue'

import router from './router'

Vue.use(BootstrapVue)

Vue.use(BootstrapVueIcons)

Vue.component('b-sidebar', BSidebar)

Vue.use(LayoutPlugin)

Vue.component('b-container', BContainer)

Vue.component('b-row', BRow)

Vue.config.productionTip = false

/* eslint-disable no-new */
new Vue({
  el: '#app',
  router,
  template: '<App/>',
  components: { App }
})
