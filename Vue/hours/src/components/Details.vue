<template>
    <div class="container-fluid mt-4">
      <h1 class="h1">Employee Details</h1>
      <!-- <b-alert :show="loading" variant="info">Loading...</b-alert> -->
      <b-row>
        <b-col>
          <table class="table table-striped">
            <thead>
              <tr>
                <th>ID</th>
                <th>Date</th>
                <th>Project</th>
                <th>Time Spent/Day</th>
                <th>Time Spent/Month</th>
                <th>&nbsp;</th>
              </tr>
            </thead>
            <tbody>
              <tr v-for="record in records" :key="record.id">
                <td>{{ record.id }}</td>
                <td>{{ record.date }}</td>
                <td>{{ record.project }}</td>
                <td>{{ record.day }}</td>
                <td> {{ record.month }}</td>
                <td class="text-right">
                  <a href="#" @click.prevent="updateFoodRecord(record)" v-b-modal.modal-1>Edit</a> -
                  <a href="#" @click.prevent="deleteFoodRecord(record.id)">Delete</a>
                </td>
              </tr>
            </tbody>
          </table>
          </b-col>
          </b-row>
          </div>
          </template>
 <script>         
import api from '@/HoursApiService';
export default {
  data() {
    return {
    result: {},
    model:{
  },
      // loading: false,
      records: [],
      model: {}
    };
},
  async created() {
    this.getAll()
  },
  methods: {
    async getAll() {
      this.loading = true

      try {
        this.records = await api.getAll()
      } finally {
        this.loading = false
      }
    },
    async updateFoodRecord(foodRecord) {
      // We use Object.assign() to create a new (separate) instance
      this.model = Object.assign({}, foodRecord)
    },
    async createFoodRecord() {
      const isUpdate = !!this.model.id;

      if (isUpdate) {
        await api.update(this.model.id, this.model)
      } else {
        await api.create(this.model)
      }

      // Clear the data inside of the form
      this.model = {}

      // Fetch all records again to have latest data
      await this.getAll()
    },
    async deleteFoodRecord(id) {
      if (confirm('Are you sure you want to delete this record?')) {
        // if we are editing a food record we deleted, remove it from the form
        if (this.model.id === id) {
          this.model = {}
        }

        await api.delete(id)
        await this.getAll()
      }
    }
  }
}
</script>