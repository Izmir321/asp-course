const addProjectDescriptionTextarea = document.getElementById('add-project-description');

const addProjectDescriptionQuill = new Quill('#add-project-description-wysiwyg-editor', {
    modules: {
        syntax: true,
        toolbar: '#add-project-description-wysiwyg-toolbar'
    },
    theme: 'snow',
    placeholder: 'Type something'
});

addProjectDescriptionQuill.on('text-change', function () {
    addProjectDescriptionTextarea.value = addProjectDescriptionQuill.root.innerHTML
})


const uploadTrigger = document.getElementById('upload-trigger')
const fileInput = document.getElementById('image-upload')
const imagePreview = document.getElementById('image-preview')
const imagePreviewIconContainer = document.getElementById('image-preview-icon-container')
const imagePreviewIcon = document.getElementById('image-preview-icon')

uploadTrigger.addEventListener('click', function () {
    fileInput.click()
})

fileInput.addEventListener('change', function (e) {
    const file = e.target.files[0]
    if (file && file.type.startsWith('image/')) {
        const reader = new FileReader()

        reader.onload = (e) => {
            imagePreview.src = e.target.result
            imagePreview.classList.remove('hide')
            imagePreviewIcon.classList.remove('fa-camera')
            imagePreviewIcon.classList.add('fa-pen-to-square')
            imagePreviewIconContainer.classList.add('selected')

        }

        reader.readAsDataURL(file)
    }
})



const modals = document.querySelectorAll('[data-type="modal"]')
modals.forEach(modal => {
    modal.addEventListener('click', function () {
        const targetId = modal.getAttribute('data-target')
        const targetElement = document.querySelector(targetId)
        console.log(targetElement)

        targetElement.classList.add('modal-show')
    })
})




const closeButtons = document.querySelectorAll('[data-type="close"]')
closeButtons.forEach(button => {
    button.addEventListener('click', function () {
        const targetId = button.getAttribute('data-target')
        const targetElement = document.querySelector(targetId)
        console.log(targetElement)

        targetElement.classList.remove('modal-show')
    })
})


const dropdownButtons = document.querySelectorAll('[data-type="dropdown"]');

document.addEventListener('click', function (event) {
    let clickedDropdown = null;

    dropdownButtons.forEach(button => {
        const targetId = button.getAttribute('data-target');
        const targetElement = document.querySelector(targetId); 

        if (button.contains(event.target)) {
            clickedDropdown = targetElement;

            
            document.querySelectorAll('.dropdown.dropdown-show').forEach(openDropdown => {
                if (openDropdown !== targetElement) {
                    openDropdown.classList.remove('dropdown-show');
                }
            });

            
            targetElement.classList.toggle('dropdown-show');
        }
    });

    
    if (!clickedDropdown && !event.target.closest('.dropdown')) {
        document.querySelectorAll('.dropdown.dropdown-show').forEach(openDropdown => {
            openDropdown.classList.remove('dropdown-show');
        });
    }
});

