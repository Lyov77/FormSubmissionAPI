<template>
  <div class="form-container">
    <form @submit.prevent="submitForm">
      <label>
        Name:
        <input type="text" v-model="formData.name" required />
      </label>

      <label>
        Email:
        <input type="email" v-model="formData.email" required />
      </label>

      <label>
        Gender:
        <input type="radio" v-model="formData.gender" value="Male" /> Male
        <input type="radio" v-model="formData.gender" value="Female" /> Female
      </label>

      <label>
        Subscription:
        <select v-model="formData.subscription">
          <option value="free">Free</option>
          <option value="premium">Premium</option>
        </select>
      </label>

      <label>
        Terms & Conditions:
        <input type="checkbox" v-model="formData.agree" />
      </label>

      <button type="submit">Submit</button>
    </form>

    <p v-if="message" class="message">{{ message }}</p>
  </div>
</template>

<script setup>
import { ref } from 'vue';
import axios from 'axios';

const formData = ref({
  name: '',
  email: '',
  gender: '',
  subscription: '',
  agree: false
});

const message = ref('');

const submitForm = async () => {
  try {
    const response = await axios.post('https://localhost:7050/api/forms/submit', {
      FormName: 'ContactForm',
      Fields: formData.value
    });
    message.value = response.data.message;
  } catch (error) {
    console.error(error);
    message.value = `Error submitting form: ${error.response ? error.response.data : error.message}`;
  }
};
</script>

<style scoped>
.form-container {
  max-width: 600px;
  margin: auto;
  background-color: rgba(255, 255, 255, 0.9);
  padding: 30px;
  border-radius: 15px;
  box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
}

form {
  display: flex;
  flex-direction: column;
}

label {
  margin-bottom: 20px;
  font-size: 1.1rem;
}

input, select {
  padding: 10px;
  font-size: 1rem;
  border: 1px solid #ccc;
  border-radius: 5px;
  margin-top: 5px;
}

button {
  background-color: #6e7dff;
  color: #fff;
  font-size: 1.2rem;
  padding: 12px 20px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  margin-top: 20px;
  transition: background-color 0.3s, transform 0.2s;
}

button:hover {
  background-color: #4e59cc;
  transform: translateY(-5px);
}

.message {
  margin-top: 20px;
  font-size: 1.1rem;
  color: #4e59cc;
  font-weight: 600;
}
</style>
