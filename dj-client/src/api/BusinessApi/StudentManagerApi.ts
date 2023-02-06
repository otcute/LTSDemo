import axiosClient from '../AxiosApi';

const StudentManagerApi: object = {
    login: (param: any) => {
        const url = `/api/product1.0/checklogin?userName=${param.userName}&userPass=${param.userPass}`;
        return axiosClient.get(url);
    },
    signin: (data: any) => {
        const url = `/api/product1.0/createaccount`;
        return axiosClient.post(url, data, {});
    },
};

export default StudentManagerApi;
