import { createRouter, createWebHistory } from 'vue-router';
import FormComponent from '../components/FormComponent.vue';
import FormList from '../components/FormList.vue';

const routes = [
  { path: '/', component: FormComponent },
  { path: '/submissions', component: FormList }
];

export default createRouter({
  history: createWebHistory(),
  routes
});
