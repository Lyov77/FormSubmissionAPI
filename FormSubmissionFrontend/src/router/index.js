import { createRouter, createWebHistory } from 'vue-router'; // Using createWebHistory for clean URLs
import FormComponent from '../components/FormComponent.vue';
import FormList from '../components/FormList.vue';

const routes = [
  { path: '/', component: FormComponent },
  { path: '/submissions', component: FormList }
];

export default createRouter({
  history: createWebHistory(), // Use history mode for clean URLs without hashes
  routes
});
