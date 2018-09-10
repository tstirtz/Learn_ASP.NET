import Vue from "vue";
import App from "./App.vue";
import Router from "./Router.vue";
import ExpenseSummary from "./components/ExpenseSummary.vue";
import VueRouter from "vue-router";

Vue.config.productionTip = false;

Vue.use(VueRouter);

const routes = [
   {path: "/", component: App},
   {path: "/summary", component: ExpenseSummary}
]

const router = new VueRouter({
    routes
})


const app = new Vue({
  components: { Router },
  template: "<Router/>",
  router
}).$mount("#app");
