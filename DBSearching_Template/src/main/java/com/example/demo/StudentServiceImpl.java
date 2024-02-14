package com.example.demo;

import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

@Service
@RequiredArgsConstructor
public class StudentServiceImpl implements StudentService {

    private final StudentRepository studentRepository;

    @Override
    public List<Student> searchStudent(String fullName) {
        // Check if the parameter includes spaces
        fullName = fullName.trim();
        boolean containsSpaces = fullName.contains(" ");
        if (containsSpaces) {
            // Parameter includes spaces
            String[] names = fullName.split("\\s+");
            String firstName = names[0];
            String lastName = names.length > 1 ? names[names.length - 1] : null;
            System.out.println(firstName + "  " + lastName);
            if (lastName != null) {
                // Try first name and last name order
                List<Student> studentList = studentRepository.findByNameContainingIgnoreCaseAndSurnameContainingIgnoreCase(firstName, lastName);
                System.out.println(studentList.toString());
                if (studentList.isEmpty()) {
                    // If no results, try vice versa order
                    studentList = studentRepository.findByNameContainingIgnoreCaseAndSurnameContainingIgnoreCase(lastName, firstName);
                    System.out.println(studentList.toString());
                    System.out.println("We're here");
                }
                return studentList;
            }
        }
        // Fallback: Search by full name
        return studentRepository.findByNameContainingIgnoreCaseOrSurnameContainingIgnoreCase(fullName, fullName);
    }
}









//        public Optional<Student> searchStudent(String search) {
//            // Split the search parameter into name and surname
//            String[] parts = search.split("\\s+");
//            String name = null;
//            String surname = null;
//            if (parts.length > 0) {
//                name = parts[0];
//            }
//            if (parts.length > 1) {
//                surname = parts[1];
//            }
//            // Call the repository method with name and surname parameters
//            return studentRepository.findByName(name, surname);
//        }
//    }



//    @Override
//    public List<Student> searchStudent(String searchParam) {
//
//        List<Student> studentsByStudentId = studentRepository.findByStudentIdContainingIgnoreCase(searchParam);
//        List<Student> students = new ArrayList<>(!studentsByStudentId.isEmpty() ? studentsByStudentId : new ArrayList<>());
//
//        List<Student> studentsBySurname = studentRepository.findBySurnameContainingIgnoreCase(searchParam);
//        students.addAll(!studentsBySurname.isEmpty() ? studentsBySurname : new ArrayList<>());
//
//        List<Student> studentsByName = studentRepository.findByNameContainingIgnoreCase(searchParam);
//        students.addAll(!studentsByName.isEmpty() ? studentsByName : new ArrayList<>());
//
//        return students;
//    }
//}


//    public List<Student> searchStudent(String searchParam) {
//        Stream<Student> studentsStream = Stream.of(
//                studentRepository.findByStudentIdContaining(searchParam).stream(),
//                studentRepository.findBySurnameContaining(searchParam).stream(),
//                studentRepository.findByNameContaining(searchParam).stream()
//        ).flatMap(s -> s);
//
//        return studentsStream.collect(Collectors.toList());
//    }

