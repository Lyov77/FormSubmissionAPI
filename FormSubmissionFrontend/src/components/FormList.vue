<template>
    <div class="form-list-container">
      <h2>Submitted Forms</h2>
  
      <div v-if="submissions.length === 0">No submissions yet.</div>
  
      <ul v-else>
        <li v-for="submission in submissions" :key="submission.id">
          <p><strong>Form Name:</strong> {{ submission.formName }}</p>
          <p><strong>Submitted At:</strong> {{ submission.submittedAt }}</p>
          <ul>
            <li v-for="(value, key) in submission.fields" :key="key">
              <strong>{{ key }}:</strong> {{ value }}
            </li>
          </ul>
        </li>
      </ul>
    </div>
  </template>
  
  <script setup>
  import { ref, onMounted } from 'vue';
  import axios from 'axios';
  
  const submissions = ref([]);
  
  const fetchSubmissions = async () => {
    try {
      console.log('Fetching submissions...');
      const response = await axios.get('https://localhost:7050/api/forms/list');
      submissions.value = response.data;
      console.log('Fetched submissions:', submissions.value);
    } catch (error) {
      console.error(error);
    }
  };
  
  onMounted(fetchSubmissions);
  </script>
  
  <style scoped>
  .form-list-container {
    max-width: 800px;
    margin: auto;
    text-align: left;
  }
  
  ul {
    list-style-type: none;
    padding: 0;
  }
  
  li {
    margin-bottom: 15px;
  }
  </style>
  