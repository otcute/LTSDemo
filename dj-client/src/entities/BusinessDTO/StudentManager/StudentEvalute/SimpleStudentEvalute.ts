export interface SimpleStudentEvalute {
    studentAvatar: string;
    studentName: string;
    studentSdt: string;
    studentCourse: string;
    studentTurtor: string;
    studentActive: boolean;
}


export const mapData = (input: any): SimpleStudentEvalute[] => {
    return input.map((element: any) => {
        return {
            studentAvatar: 'https://img.meta.com.vn/Data/image/2021/09/22/anh-meo-cute-de-thuong-dang-yeu-41.jpg',
            studentName: element.studentLAName,
            studentSdt: element.studentLASdt,
            studentCourse: '13',
            studentTurtor: element.employeeLAName,
            studentActive: true 
        }
    })
}