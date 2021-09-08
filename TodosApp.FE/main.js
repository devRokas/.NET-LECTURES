// variables
var todoForm = document.getElementById("todo-form");
var todoList = document.getElementById("todos");
var doneList = document.getElementById("dones");
var todoInput = document.getElementById("todo-input");
var editInput = document.getElementById('edit-input');

window.onload = async () => {
  const todos = await getTodos();

  todos.forEach(todo => {
    var todoItem = `
    <div class="border border-1 shadow-sm p-3 mb-3 rounded todo-item" data-id=${todo.id}>
        <h4 class="mb-3 input-name">${todo.title}</h4>
        <button type="button" class="btn btn-danger delete">Delete</button>
        <button type="button" class="btn btn-success move-todo">Move to Done</button>
        <button type="button" class="btn btn-warning edit" data-bs-toggle="modal"
            data-bs-target="#edit-modal">Edit</button>
    </div>
    `;
todoList.innerHTML += todoItem;
  })
}

todoForm.addEventListener("submit", function (e) {
  e.preventDefault();

  if (todoInput.value.length > 0) {
    todoInput.classList.remove("is-invalid");
    var todoItem = `
        <div class="border border-1 shadow-sm p-3 mb-3 rounded todo-item">
            <h4 class="mb-3 input-name">${todoInput.value}</h4>
            <button type="button" class="btn btn-danger delete">Delete</button>
            <button type="button" class="btn btn-success move-todo">Move to Done</button>
            <button type="button" class="btn btn-warning edit" data-bs-toggle="modal"
                data-bs-target="#edit-modal">Edit</button>
        </div>
        `;
    todoList.innerHTML += todoItem;
    todoForm.reset();
  } else {
    todoInput.classList.add("is-invalid");
  }
});

// Todo item card actions
document.addEventListener("click", async function (e) {
  if (e.target.matches(".delete")) {
    location.reload(); // perkrauna puslapi
    e.target.closest(".todo-item").remove();
    return;
  }

  if (e.target.matches(".move-todo")) {
    var card = e.target.closest(".todo-item");
    
    if (e.target.innerText == "Move to Done") {
      e.target.innerText = "Move back";
      doneList.appendChild(card);
      return;
    }

    e.target.innerText = "Move to Done";
    todoList.appendChild(card);
  }
});
